using ForumNineNine.DataAccess.DomainModels;
using ForumNineNine.WebModels.AccountViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumNineNine.DataAccess.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterViewModel model);
        SignInResult Login(LoginViewModel model);
        void Logout();
        User GetById(string userId);
        IEnumerable<User> GetAll();
        int SetProfileImage(User user, string filename);
        int IncrementRating(string userId, Type type);


    }
}
