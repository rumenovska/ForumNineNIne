using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ForumNineNine.DataAccess.DomainModels;
using ForumNineNine.DataAccess.Interfaces;
using ForumNineNine.WebModels.AccountViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ForumNineNine.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserService _userService;
        private readonly IUploader _uploader;
        private readonly IHostingEnvironment _hostingEnvironment;

        public ProfileController(UserManager<User> userManager, IUserService userService, IUploader uploader, IHostingEnvironment hostingEnvironment)
        {
            _userManager = userManager;
            _userService = userService;
            _uploader = uploader;
            _hostingEnvironment = hostingEnvironment;

        }

        public IActionResult Detail(string userId, string errorMassage = null)
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
                ErrorMassage = errorMassage,
                IsAdmin = _userManager.IsInRoleAsync(user, "admin").Result
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult UploadProfileImage(IFormFile file)
        {
            //getting current user
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            if (file == null)
            {
                return RedirectToAction("Detail", new { userId = user.Id, errorMassage = "Please select a JPG or PNG file" });
            }
            else if (Path.GetExtension(file.FileName) == ".jpg" || Path.GetExtension(file.FileName) == ".png")
            {
                // geting the path to the images folder
                string mainFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                //getting the extension of the picture
                var extension = Path.GetExtension(file.FileName);
                //getting info for the images folder so we can manipulate whit it
                DirectoryInfo dataFolder = new DirectoryInfo(mainFolder);
                //creating users folder if we dont have one
                var usersFolder = dataFolder.CreateSubdirectory("users");
                //renaming the picture to the username
                string uniqueFileName = user.UserName + extension;
                //getting the folder path to which  the pictures will save to
                string filePath = Path.Combine(usersFolder.FullName, uniqueFileName);
                //opening a file stream 
                var myFile = new FileStream(filePath, FileMode.Create);
                //coping the file to the opened file stream
                file.CopyTo(myFile);
                //closing the file
                myFile.Close();
                //updating the user
                _userService.SetProfileImage(user, uniqueFileName);

                return RedirectToAction("Detail", new { userId = user.Id });
            }
            return RedirectToAction("Detail", new { userId = user.Id, errorMassage = "Please select a JPG or PNG file" });
        }
          
    }
}