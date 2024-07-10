using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using POO_Examen3.Entities;

namespace POO_Examen3
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Category> CategoryToys { get; set; }

        public DbSet<Kind> KindToys { get; set;}
        public DbSet<Toy> Toys { get; set;}

         protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        
        modelBuilder.Entity<Toy>()
            .HasOne(t => t.Category)
            .WithMany(c => c.Toys)
            .HasForeignKey(t => t.Id);

        modelBuilder.Entity<Toy>()
            .HasOne(t => t.Kind)
            .WithMany(k => k.Toys)
            .HasForeignKey(t => t.Id);
    }
    }
}