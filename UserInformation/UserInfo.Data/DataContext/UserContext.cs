using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UserInfo.Data.Entities;

namespace UserInfo.Data.DataContext
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(u =>
            {
                u.Property(_ => _.Id).ValueGeneratedOnAdd();
                u.HasKey(_ => _.Id);
                u.Property(_ => _.Name).IsRequired();
                u.Property(_ => _.Surname).IsRequired();
            });
        }
    }
}