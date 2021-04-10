using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TeamHub_MVP.Models;

namespace TeamHub_MVP.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Project to Team Many To Many
            modelBuilder.Entity<UserProject>().HasKey(up => new { up.UserID, up.ProjectID }); // Composite Key
            modelBuilder.Entity<UserProject>().HasOne(up => up.User).WithMany(u => u.Projects).HasForeignKey(up => up.UserID);
            modelBuilder.Entity<UserProject>().HasOne(up => up.Project).WithMany(p => p.Users).HasForeignKey(up => up.ProjectID);

            //Many To Many
            //-------------
           

            //One to One
            //------------
            // modelBuilder.Entity<Student>()
            //.HasOne<StudentAddress>(s => s.Address)
            //.WithOne(ad => ad.Student)
            //.HasForeignKey<StudentAddress>(ad => ad.AddressOfStudentId);


            //One to Many
            //-------------
            //modelBuilder.Entity<Student>()
            //.HasOne<Grade>(s => s.Grade)
            //.WithMany(g => g.Students)
            //.HasForeignKey(s => s.CurrentGradeId);

        }

    }
}
