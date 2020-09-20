using System;
using System.Collections.Generic;
using System.Text;
using ForumNineNine.DataAccess.DomainModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ForumNineNine.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){ }

        DbSet<Forum> Forums { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<PostReply> Replies { get; set; }

    }
}
