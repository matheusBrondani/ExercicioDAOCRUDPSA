﻿// <auto-generated />
using System;
using ExercicioDAOCRUD;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExercicioDAOCRUD.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExercicioDAOCRUD.PL.Actor", b =>
                {
                    b.Property<int>("ActorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateBirth");

                    b.Property<string>("Name");

                    b.HasKey("ActorID");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("ExercicioDAOCRUD.PL.ActorMovie", b =>
                {
                    b.Property<int>("ActorMovieID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ActorID");

                    b.Property<string>("Character");

                    b.Property<int>("MovieId");

                    b.HasKey("ActorMovieID");

                    b.HasIndex("MovieId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("ExercicioDAOCRUD.PL.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("ExercicioDAOCRUD.PL.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Director");

                    b.Property<int>("GenreID");

                    b.Property<decimal>("Gross");

                    b.Property<double>("Rating");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("GenreID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("ExercicioDAOCRUD.PL.ActorMovie", b =>
                {
                    b.HasOne("ExercicioDAOCRUD.PL.Movie")
                        .WithMany("ActorMovie")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExercicioDAOCRUD.PL.Movie", b =>
                {
                    b.HasOne("ExercicioDAOCRUD.PL.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
