using ForumNineNine.WebModels.AccountViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForumNineNine.DataAccess.Interfaces
{
    public interface IUserService
    {
        void Register(RegisterViewModel model);
        void Login(LoginViewModel model);
        void Logout();


    }
}
