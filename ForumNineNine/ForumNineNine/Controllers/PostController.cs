using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumNineNine.DataAccess.DomainModels;
using ForumNineNine.DataAccess.Interfaces;
using ForumNineNine.Models.PostViewModels;
using ForumNineNine.Models.ReplyViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForumNineNine.Controllers
{
    public class PostController : Controller
    {
        private readonly IPost _postService;
        private readonly IForum _forumService;
        private readonly UserManager<User> _userManager;
        public PostController(IPost postService, IForum forumService, UserManager<User> userManager)
        {
            _postService = postService;
            _forumService = forumService;
            _userManager = userManager;
        }
        public IActionResult Index(int postId)
        {
            var post = _postService.GetById(postId);
            var replies = RepliesMapper(post.Replies);
            var model = new PostIndexModel
            {
                Id = post.Id,
                Title = post.Title,
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                AuthorImageUrl = post.User.ProfileImageUrl,
                AuthorRating = post.User.Rating,
                Created = post.Created,
                PostContent = post.Content,
                Replies = replies,
                ForumName = post.Forum.Title,
                ForumId = post.Forum.Id,
                IsAuthorAdmin = _userManager.GetRolesAsync(post.User).Result.Contains("Admin")
            };
            return View(model);
        }
        public IActionResult Create(int forumId)
        {
            var forum = _forumService.GetById(forumId);
            var newPostViewModel = new NewPostViewModel
            {
                ForumName= forum.Title,
                ForumId= forum.Id,
                ForumImageUrl= forum.ImageUrl,
                AuthorName = User.Identity.Name
            };
            return View(newPostViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewPostViewModel model)
        {
            var user = _userManager.FindByNameAsync(model.AuthorName).Result;
            var forum = _forumService.GetById(model.ForumId);
            var post = new Post
            {
                User = user,
                Title= model.Title,
                Content= model.Content,
                Created= DateTime.Now,
                Forum= forum
            };

            _postService.Add(post).Wait();
            return RedirectToAction("Index", "Post", new {postId= post.Id });
        }
        private IEnumerable<PostReplyVIewModel> RepliesMapper(IEnumerable<PostReply> replies)
        {
            return replies.Select(r => new PostReplyVIewModel
            {
                Id = r.Id,
                AuthorId = r.User.Id,
                AuthorName = r.User.UserName,
                AuthorImageUrl = r.User.ProfileImageUrl,
                AuthorRating = r.User.Rating,
                Created = r.Created,
                ReplyContent= r.Content,
                IsAuthorAdmin= _userManager.GetRolesAsync(r.User).Result.Contains("Admin")
            });
        }
    }
}