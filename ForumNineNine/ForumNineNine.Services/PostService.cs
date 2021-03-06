﻿using ForumNineNine.DataAccess;
using ForumNineNine.DataAccess.DomainModels;
using ForumNineNine.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumNineNine.Services
{
    public class PostService : IPost
    {
        private readonly ApplicationDbContext _context;
        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task Add(Post post)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> FromAllSearchedPosts(string searchQuery)
        {
            return GetAll().Where(post => post.Title.Contains(searchQuery) || post.Content.Contains(searchQuery));
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts
                .Include(p => p.User)
                .Include(p => p.Forum)
                .Include(p => p.Replies)
                    .ThenInclude(r => r.User);
        }

        public Post GetById(int id)
        {
            return _context.Posts.Where(p=> p.Id == id)
                .Include(p => p.User)
                .Include(p => p.Forum)
                .Include(p => p.Replies)
                    .ThenInclude(r => r.User)
                .FirstOrDefault();
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetForumPosts(int forumId)
        {
            return _context.Forums.FirstOrDefault(f => f.Id == forumId).Posts;
        }

        public IEnumerable<Post> GetLatestPosts(int n)
        {
            return GetAll().OrderByDescending(p => p.Created).Take(n);
        }

        public IEnumerable<Post> GetSearchedPosts(Forum forum, string searchQuery)
        {
            
            return string.IsNullOrEmpty(searchQuery) ? forum.Posts
                : forum.Posts.Where(post => post.Title.Contains(searchQuery) || post.Content.Contains(searchQuery));
        }

        public int AddReply(PostReply postReply)
        {
            _context.Replies.Add(postReply);
            return _context.SaveChanges();
        }
    }
}
