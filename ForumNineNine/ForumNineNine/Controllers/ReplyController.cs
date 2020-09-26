using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumNineNine.DataAccess.DomainModels;
using ForumNineNine.DataAccess.Interfaces;
using ForumNineNine.Models.ReplyViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForumNineNine.Controllers
{
    public class ReplyController : Controller
    {
        private readonly IPost _postService;
        private readonly UserManager<User> _userManager;
        private readonly IUserService _userService;
        public ReplyController(IPost postService, UserManager<User> userManager, IUserService userService)
        {
            _postService = postService;
            _userManager = userManager;
            _userService = userService;
        }

        public IActionResult Create(int postId)
        {
            var post = _postService.GetById(postId);
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            var model = new PostReplyVIewModel
            {
                PostContent = post.Content,
                PostId = post.Id,
                PostTitle = post.Title,

                AuthorId = user.Id,
                AuthorName = user.UserName,
                AuthorRating = user.Rating,
                AuthorImageUrl = user.ProfileImageUrl,
                IsAuthorAdmin = User.IsInRole("admin"),
                
                ForumId= post.Forum.Id,
                ForumImageUrl = post.Forum.ImageUrl,
                ForumName = post.Forum.Title,

                Created = DateTime.Now

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddReply(PostReplyVIewModel model)
        {
            var user = _userManager.FindByIdAsync(model.AuthorId).Result;
            var post = _postService.GetById(model.PostId);
            var reply = new PostReply
            {
                Post = post,
                Content = model.ReplyContent,
                Created = DateTime.Now,
                User = user
            };
            _postService.AddReply(reply);
            _userService.IncrementRating(user.Id, typeof(PostReply));
            return RedirectToAction("Index", "Post", new {postId= model.PostId });
        }
    }
} 