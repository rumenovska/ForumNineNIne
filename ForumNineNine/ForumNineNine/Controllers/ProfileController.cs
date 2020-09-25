using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumNineNine.DataAccess.DomainModels;
using ForumNineNine.DataAccess.Interfaces;
using ForumNineNine.WebModels.AccountViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForumNineNine.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserService _userService;
        private readonly IUploader _uploader;

        public ProfileController(UserManager<User> userManager, IUserService userService, IUploader uploader)
        {
            _userManager = userManager;
            _userService = userService;
            _uploader = uploader;
        }

        public IActionResult Detail(string userId)
        {
            var user = _userManager.FindByIdAsync(userId).Result;

            var model = new ProfileModel
            {
                UserId = user.Id,
                UserName = user.UserName,
                UserRating = user.Rating.ToString(),
                Email = user.Email,
                ProfileImageUrl = user.ProfileImageUrl,
                MemeberSince = user.MemberSince,
                IsAdmin = _userManager.IsInRoleAsync(user, "Admin").Result
            };

            return View(model);
        }
    }
}