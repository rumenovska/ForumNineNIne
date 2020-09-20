using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumNineNine.DataAccess.Interfaces;
using ForumNineNine.Models.ForumViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace ForumNineNine.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }
        public IActionResult Index()
        {
            var forums = _forumService.GetAll().Select(f => new ForumViewModel
            {
                 Id= f.Id,
                 Name = f.Title,
                 Description = f.Description
            });

            var model = new ForumIndexModel
            {
                ForumList = forums
            };
            return View(model);
        }

        public IActionResult Topic(int id)
        {
            var forum = _forumService.GetById(id);
            return View(forum);

        }
    }
}