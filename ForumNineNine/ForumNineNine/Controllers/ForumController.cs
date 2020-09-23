using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumNineNine.DataAccess.DomainModels;
using ForumNineNine.DataAccess.Interfaces;
using ForumNineNine.Models.ForumViewModels;
using ForumNineNine.Models.PostViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Options;

namespace ForumNineNine.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;
        public ForumController(IForum forumService, IPost postService)
        {
            _forumService = forumService;
            _postService = postService;
        }
        public IActionResult Index()
        {
            var forums = _forumService.GetAll().Select(f => new ForumViewModel
            {
                 Id= f.Id,
                 Name = f.Title,
                 Description = f.Description,
                 PostsCount = f.Posts.Count()
                 
            });
            
            var model = new ForumIndexModel
            {
                ForumList = forums
            };
            return View(model);
        }

        public IActionResult Topic(int forumId)
        {
            var forum = _forumService.GetById(forumId);
            var posts = _postService.GetForumPosts(forumId);

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

        private ForumViewModel ForumViewModelMapper(Forum forum)
        {
            return new ForumViewModel
            {
                Id= forum.Id,
                Description= forum.Description,
                Name= forum.Title,
                ImageUrl= forum.ImageUrl
            };
        }
    }
}