
using ForumNineNine.DataAccess.DomainModels;
using ForumNineNine.DataAccess.Interfaces;
using ForumNineNine.WebModels.AccountViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumNineNine.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public void Login(LoginViewModel model)
        {
            var result = _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false).Result;
            if (result.IsNotAllowed)
            {
                throw new Exception("Username od password is not correct");
            }
        }

        public void Logout()
        {
            _signInManager.SignOutAsync();
        }

        public void Register(RegisterViewModel model)
        {
            var user = new User { UserName = model.Email };
            var result = _userManager.CreateAsync(user, model.Password).Result;
            if (result.Succeeded)
            {
                Login(new LoginViewModel
                {
                    Username= model.Email,
                    Password= model.Password
                });
            }
        }
    }
}
