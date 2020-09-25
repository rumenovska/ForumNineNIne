using System;
using System.Collections.Generic;
using System.Text;
using ForumNineNine.DataAccess.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ForumNineNine.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Forum> Forums { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostReply> Replies { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string adminId = Guid.NewGuid().ToString();
            // ADMIN ROLE ID
            string adminRoleId = Guid.NewGuid().ToString();
           

            modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = adminRoleId,
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = adminId,
                UserName = "admin@mail.com",
                NormalizedUserName = "admin@mail.com".ToUpper(),
                Email = "admin@mail.com",
                NormalizedEmail = "admin@mail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin123."),
                SecurityStamp = string.Empty
            });
            // ADD CONNECTION BETWEEN SUPPLIER ROLE AND SUPPLIER USER TO HAVE ADMIN RIGHTS
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminId
            });


        }
    }
}
