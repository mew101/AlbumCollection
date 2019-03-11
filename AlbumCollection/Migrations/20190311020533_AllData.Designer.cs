﻿// <auto-generated />
using AlbumCollection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumCollection.Migrations
{
    [DbContext(typeof(AlbumContext))]
    [Migration("20190311020533_AllData")]
    partial class AllData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbumCollection.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Artist");

                    b.Property<string>("ImgPath");

                    b.Property<string>("Name");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");

                    b.HasData(
                        new { AlbumId = 1, Artist = "Fred Mollin & Greg Diakun", ImgPath = "/Images/DisneyLullaby.png", Name = "Disney's Lullaby Album" },
                        new { AlbumId = 2, Artist = "Jack Johnson", ImgPath = "/Images/CuriousGeorge.png", Name = "Sing - A - Longs & Lullabies for the Film Curious George" },
                        new { AlbumId = 3, Artist = "Parkers Friends", ImgPath = "/Images/CabbagePatch.png", Name = "Cabbage Patch" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("Title");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new { SongId = 1, AlbumId = 1, Title = " Twinkle Twinkle Little Star" },
                        new { SongId = 2, AlbumId = 1, Title = "Baby Mine" },
                        new { SongId = 3, AlbumId = 1, Title = "House at Pooh Corner" },
                        new { SongId = 4, AlbumId = 2, Title = "Upside Down" },
                        new { SongId = 5, AlbumId = 2, Title = "People Watching" },
                        new { SongId = 6, AlbumId = 2, Title = "Wrong Turn" },
                        new { SongId = 7, AlbumId = 3, Title = "Cabbage Patch Theme" },
                        new { SongId = 8, AlbumId = 3, Title = "Babyland" },
                        new { SongId = 9, AlbumId = 3, Title = "Villains Three" }
                    );
                });

            modelBuilder.Entity("AlbumCollection.Models.Song", b =>
                {
                    b.HasOne("AlbumCollection.Models.Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
