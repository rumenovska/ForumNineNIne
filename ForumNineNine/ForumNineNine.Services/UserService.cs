
using ForumNineNine.DataAccess;
using ForumNineNine.DataAccess.DomainModels;
using ForumNineNine.DataAccess.Interfaces;
using ForumNineNine.WebModels.AccountViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumNineNine.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationDbContext _context;

        public UserService(UserManager<User> userManager, SignInManager<User> signInManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User GetById(string userId)
        {
            throw new NotImplementedException();
        }

        public Task IncrementRating(string userId, Type type)
        {
            throw new NotImplementedException();
        }

        public SignInResult Login(LoginViewModel model)
        {
            var result = _signInManager.PasswordSignInAsync(model.Username, model.Password, false, false).Result;
            return result;
        }

        public void Logout()
        {
            _signInManager.SignOutAsync();
        }

        public void Register(RegisterViewModel model)
        {
            var user = new User { 
                UserName = model.Username,
                Email= model.Email,
                MemberSince = DateTime.Now,
                ProfileImageUrl="/images/users/default-user.png"
            };
            var result = _userManager.CreateAsync(user, model.Password).Result;
            if (result.Succeeded)
            {
                Login(new LoginViewModel
                {
                    Username= model.Username,
                    Password= model.Password
                });
            }
        }

        public int SetProfileImage(User user, string filename)
        {
            user.ProfileImageUrl = $"/images/users/{filename}";
            _context.Users.Update(user);
            return _context.SaveChanges();
        }
    }
}
