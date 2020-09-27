using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumNineNine.DataAccess.DomainModels;
using ForumNineNine.DataAccess.Interfaces;
using ForumNineNine.Models.ForumViewModels;
using ForumNineNine.Models.PostViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;

namespace ForumNineNine.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;
        private readonly UserManager<User> _userManager;
        private readonly IUserService _userService;
        public ForumController(IForum forumService, IPost postService, UserManager<User> userManager, IUserService userService)
        {
            _forumService = forumService;
            _postService = postService;
            _userManager = userManager;
            _userService = userService;
        }

        public IActionResult Index()
        {
            var forums = _forumService.GetAll().Select(f => ForumViewModelMapper(f));


            var model = new ForumIndexModel
            {
                ForumList = forums
            };
            return View(model);
        }

        public IActionResult Topic(int forumId, string searchQuery)
        {
            var forum = _forumService.GetById(forumId);
            var posts = _postService.GetSearchedPosts(forum, searchQuery);

            var postViewModels = posts.Select(post => new PostViewModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                AuthorName= post.User.UserName,
                Title = post.Title,
                DatePosted = post.Created.ToString("dd/MM/yyyy"),
                RepliesCount= post.Replies.Count(),
                Forum= ForumViewModelMapper(forum)
            });
            var model = new ForumTopicModel
            {
                Posts = postViewModels,
                Forum = ForumViewModelMapper(forum)
            };

            return View(model);

        }
        [HttpPost]
        public IActionResult Search(int forumId, string searchQuery)
        {
            return RedirectToAction("Topic", new { forumId, searchQuery });
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ForumViewModel forum)
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            var model = new Forum
            {
                Title = forum.Name,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl,
                Created = DateTime.Now,
                User = user
            };

            _forumService.Create(model);
            _userService.IncrementRating(user.Id, typeof(Forum)); 
            return RedirectToAction("Index", "Forum");
        }

        private ForumViewModel ForumViewModelMapper(Forum forum)
        {
            return new ForumViewModel
            {
                Id= forum.Id,
                Description= forum.Description,
                Name= forum.Title,
                ImageUrl= forum.ImageUrl,
                UserName = forum.User.UserName,
                UserRating= forum.User.Rating,
                Created = forum.Created,
                UserId = forum.User.Id
            };
        }

        

    }
}