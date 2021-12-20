using Barent.Models;
using Barnet.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Advice> Advice { get; set; }
        public DbSet<Articles> Articles { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Services> Service { get; set; }
        public DbSet<ServicesCategory> ServicesCategories { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<Solution> Solution { get; set; }
        public DbSet<SolutionCategory> SolutionCategories { get; set; }
        public DbSet<Sosial> Sosial { get; set; }
        public DbSet<Subscribe> Subscribe { get; set; }
        public DbSet<Twitter> Twitter { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }


    }

}
