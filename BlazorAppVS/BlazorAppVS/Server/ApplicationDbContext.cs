using BlazorAppVS.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppVS.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GenderMovie>().HasKey(x => new { x.GenderId, x.MovieId });
            modelBuilder.Entity<MovieActor>().HasKey(x => new { x.MovieId, x.PeopleId });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<GenderMovie> GenderMovies { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Gender> Genders {get; set;}
        public DbSet<People> Peoples {get; set;}
        public DbSet<MovieActor> MoviesActor { get; set; }

    }
}
