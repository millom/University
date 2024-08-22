﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using University.API.Models.Entities;

namespace University.API.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext (DbContextOptions<UniversityContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student => Set<Student>();
       // public DbSet<Enrollment> Enrollment => Set<Enrollment>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder); 
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Student>().HasData(
            //    new Student { Id = 1, FirstName = "Kalle1", LastName = "Anka", Avatar = "123" },
            //    new Student { Id = 2, FirstName = "Kalle2", LastName = "Anka", Avatar = "123" },
            //    new Student { Id = 3, FirstName = "Kalle3", LastName = "Anka", Avatar = "123" }
            //    );

            //modelBuilder.Entity<Address>().HasData(
            //    new Address { Id = 1, City = "Stockholm", ZipCode = "123", Street = "Kungsgatan", StudentId = 1 },
            //    new Address { Id = 2, City = "Stockholm", ZipCode = "123", Street = "Kungsgatan", StudentId = 2 },
            //    new Address { Id = 3, City = "Stockholm", ZipCode = "123", Street = "Kungsgatan", StudentId = 3 }
            //    );
        }
    }
}
