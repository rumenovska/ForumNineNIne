using ForumNineNine.DataAccess.DomainModels;
using ForumNineNine.WebModels.AccountViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumNineNine.DataAccess.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterViewModel model);
        void Login(LoginViewModel model);
        void Logout();
        User GetById(string userId);
        IEnumerable<User> GetAll();

        Task SetProfileImage(string userId, Uri uri);
        Task IncrementRating(string userId, Type type);


    }
}
