using lab4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Configuration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.ToTable("Blogs");
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder
                .HasMany(x => x.Posts)
                .WithOne(x => x.Blog);
            builder
                .HasOne(x => x.Author);
        }
    }
}
