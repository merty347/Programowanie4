using lab4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4
{
    class BlogContext : DbContext
    {
        //public DbSet<Blog> Blog;
        //public DbSet<Post> Post;
        //public DbSet<VideoPost> VideoPost { get; set; }
        //public DbSet<PodcastPost> PodcastPost { get; set; }
        //public DbSet<TextPost> TextPost { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-HTN63BU; Initial Catalog = Blog; Integrated Security = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration
            modelBuilder.Entity<VideoPost>();
            modelBuilder.Entity<PodcastPost>();
            modelBuilder.Entity<TextPost>();
        }

        public static readonly ILoggerFactory MyLoggerFactory
           = LoggerFactory.Create(builder => { builder.AddConsole(); });
    }
}
