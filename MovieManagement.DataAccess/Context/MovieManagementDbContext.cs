using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entity;

namespace MovieManagement.DataAccess.Context;

public  class MovieManagementDbContext : DbContext
{
    public MovieManagementDbContext(DbContextOptions<MovieManagementDbContext> options)
        : base(options)
    {
        
    }

    public DbSet<Movie> Movies { get; set; } 
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Biography> Biographies { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>()
            .HasData(
                new Actor { Id = 1, FirstName = "Jackie", LastName = "Chan" },
                new Actor { Id = 2, FirstName = "John", LastName = "Senna" },
                new Actor { Id = 3, FirstName = "Steven", LastName = "Jackson" }
            );
        modelBuilder.Entity<Movie>()
            .HasData(
                new Movie { Id = 1, Name = "Lion of Judah", Description = "Cinema", ActorId = 1 },
                new Movie { Id = 2, Name = "Wakanda Forever", Description = "Box office is coming", ActorId = 2 },
                new Movie { Id = 3, Name = "Spiderman", Description = "Sky Scraper", ActorId = 1 },
                new Movie { Id = 4, Name = "Transporter", Description = "Driving skills", ActorId =3 }
            );
    }
}