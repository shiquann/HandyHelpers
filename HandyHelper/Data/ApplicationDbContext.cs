﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HandyHelper.Models;

namespace HandyHelper.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Job>()
                .HasMany(j => j.Comments)
                .WithOne(c => c.Job);

            builder.Entity<Comment>()
                .Property(f => f.DateTime)
                .HasColumnType("dateTime2");
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
