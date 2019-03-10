using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=AlbumCollection;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                new Album()
                {
                    AlbumId = 1,
                    Name = "Disney's Lullaby Album",
                    Artist = "Fred Mollin & Greg Diakun",
                    ImgPath = "/Images/DisneyLullaby.png"
                },
                new Album()
                {
                    AlbumId = 2,
                    Name = "Sing - A - Longs & Lullabies for the Film Curious George",
                    Artist = "Jack Johnson",
                    ImgPath = "/Images/CuriousGeorge.png",
                },
                new Album()
                {
                    AlbumId = 3,
                    Name = "Cabbage Patch",
                    Artist = "Parkers Friends",
                    ImgPath = "/Images/CabbagePatch.png",
                });
                }
    }

}
