﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movil.Models
{
    public class ApplicationContext : IdentityDbContext<AppUser>
    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            modelBuilder.Entity<CategoryCourse>().HasKey(t => new { t.IdCategory, t.IdCourse });

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Usuario", NormalizedName = "Usuario" });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Profesor", NormalizedName = "Profesor" });

            //modelBuilder.Entity<Category>().HasData(new Category { Id = Guid.NewGuid(), Name = "Matemáticas", Status = true });
            //modelBuilder.Entity<Category>().HasData(new Category { Id = Guid.NewGuid(), Name = "Baile", Status = true });
            //modelBuilder.Entity<Category>().HasData(new Category { Id = Guid.NewGuid(), Name = "Peluquería", Status = true });
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryCourse> CategoryCourses { get; set; }
        //public DbSet<AppUser> AppUser { get; set; }
    }
}
