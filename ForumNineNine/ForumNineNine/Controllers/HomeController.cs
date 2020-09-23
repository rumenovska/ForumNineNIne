using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ForumNineNine.Models;
using ForumNineNine.DataAccess.Interfaces;
using ForumNineNine.Models.PostViewModels;
using ForumNineNine.Models.ForumViewModels;

namespace ForumNineNine.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPost _postService;
        private readonly IForum _forumService;

        public HomeController(IPost postService, IForum forumService)
        {
            _postService = postService;
            _forumService = forumService;
        }

        public IActionResult Index()
        {
            var latestPosts = _postService.GetLatestPosts(10);
            var latestForums = _forumService.GetLatestForums(10);
            var latestPostsMapped = latestPosts.Select(p => new PostViewModel
            {
                Id = p.Id,
                Title = p.Title,
                AuthorId = p.User.Id,
                AuthorName = p.User.UserName,
                AuthorRating = p.User.Rating,
                DatePosted = p.Created.ToString(),
                RepliesCount = p.Replies.Count(),
                Forum = new ForumViewModel
                {
                    Id = p.Forum.Id,
                    Name = p.Forum.Title,
                    ImageUrl = p.Forum.ImageUrl
                }

            });
            var latestForumsMapped = latestForums.Select(f => new ForumViewModel
            {
                Id = f.Id,
                Name = f.Title,
                Description = f.Description,
                PostsCount = f.Posts.Count()
            });

            var model = new ForumIndexModel
            {
                ForumList = latestForumsMapped,
                LatestPosts= latestPostsMapped 
            };

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
