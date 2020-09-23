using ForumNineNine.DataAccess;
using ForumNineNine.DataAccess.DomainModels;
using ForumNineNine.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumNineNine.Services
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _context;
        public ForumService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task Create(Forum forum)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int forumId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> GetAll()
        {
            return _context.Forums
                .Include(f => f.Posts);
        }

        public IEnumerable<User> GetAllActiveUsers()
        {
            throw new NotImplementedException();
        }

        public Forum GetById(int id)
        {
            return _context.Forums.Where(p=> p.Id == id)
                .Include(f=> f.Posts)
                   .ThenInclude(p=> p.User)
                .Include(f => f.Posts)
                    .ThenInclude(p => p.Replies)
                        .ThenInclude(r=> r.User)    
                .FirstOrDefault();
        }

        public Task UpdateForumDescription(int forumId, string newDesc)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumTitle(int forumId, string newTitle)
        {
            throw new NotImplementedException();
        }
    }
}
