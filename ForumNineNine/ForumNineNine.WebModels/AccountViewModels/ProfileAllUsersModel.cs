using System;
using System.Collections.Generic;
using System.Text;

namespace ForumNineNine.WebModels.AccountViewModels
{
    public class ProfileAllUsersModel
    {
        public IEnumerable<ProfileViewModel> Profiles { get; set; }
    }
}
