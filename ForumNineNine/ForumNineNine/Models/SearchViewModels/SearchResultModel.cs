using ForumNineNine.Models.PostViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumNineNine.Models.SearchViewModels
{
    public class SearchResultModel
    {
        public IEnumerable<PostViewModel> Posts { get; set; }
        public string SearchQuery { get; set; }
        public bool EmptySearchQuery { get; set; }

    }
}
