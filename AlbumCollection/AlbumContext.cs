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

            modelBuilder.Entity<Song>().HasData(
                new Song()
                {
                    SongId = 1,
                    Title = " Twinkle Twinkle Little Star",
                    AlbumId = 1
                },
                new Song()
                {
                    SongId = 2,
                    Title = "Baby Mine",
                    AlbumId = 1
                },
                new Song()
                {
                    SongId = 3,
                    Title = "House at Pooh Corner",
                    AlbumId = 1
                },

                new Song()
                {
                    SongId = 4,
                    Title = "Upside Down",
                    AlbumId = 2
                },
                new Song()
                {
                    SongId = 5,
                    Title = "People Watching",
                    AlbumId = 2
                },
                new Song()
                {
                    SongId = 6,
                    Title = "Wrong Turn",
                    AlbumId = 2
                },

                new Song()
                {
                    SongId = 7,
                    Title = "Cabbage Patch Theme",
                    AlbumId = 3
                },
                new Song()
                {
                    SongId = 8,
                    Title = "Babyland",
                    AlbumId = 3
                },
                new Song()
                {
                    SongId = 9,
                    Title = "Villains Three",
                    AlbumId = 3
                });
            base.OnModelCreating(modelBuilder);
        }
    }

}
