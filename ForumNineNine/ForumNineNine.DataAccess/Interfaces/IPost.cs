using ForumNineNine.DataAccess.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ForumNineNine.DataAccess.Interfaces
{
    public interface IPost
    {
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<Post> GetForumPosts(int forumId);
        IEnumerable<Post> GetLatestPosts(int n);
        Task Add(Post post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
        IEnumerable<Post> GetSearchedPosts(Forum forum, string searchQuery);
        IEnumerable<Post> FromAllSearchedPosts(string searchQuery);
    }
}
