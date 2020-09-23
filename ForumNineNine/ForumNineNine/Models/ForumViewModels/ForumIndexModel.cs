using ForumNineNine.Models.PostViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumNineNine.Models.ForumViewModels
{
    public class ForumIndexModel
    { 
       public string SearchQuery { get; set; }
       public IEnumerable<ForumViewModel> ForumList { get; set; }
       public IEnumerable<PostViewModel> LatestPosts { get; set; }
    }
}
