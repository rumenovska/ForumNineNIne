using ForumNineNine.DataAccess.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumNineNine.Models.ForumViewModels
{
    public class ForumViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int PostsCount { get; set; }
        public DateTime Created { get; set; }

        public string UserName { get; set; }
        public string UserId { get; set; }
        public int UserRating { get; set; }
    }
}
