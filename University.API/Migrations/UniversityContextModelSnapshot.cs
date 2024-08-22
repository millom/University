﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using University.API.Data;

#nullable disable

namespace University.API.Migrations
{
    [DbContext(typeof(UniversityContext))]
    partial class UniversityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("University.API.Models.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Address", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Stockholm",
                            Street = "Kungsgatan",
                            StudentId = 1,
                            ZipCode = "123"
                        },
                        new
                        {
                            Id = 2,
                            City = "Stockholm",
                            Street = "Kungsgatan",
                            StudentId = 2,
                            ZipCode = "123"
                        },
                        new
                        {
                            Id = 3,
                            City = "Stockholm",
                            Street = "Kungsgatan",
                            StudentId = 3,
                            ZipCode = "123"
                        });
                });

            modelBuilder.Entity("University.API.Models.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Avatar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Student", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avatar = "123",
                            FirstName = "Kalle1",
                            LastName = "Anka"
                        },
                        new
                        {
                            Id = 2,
                            Avatar = "123",
                            FirstName = "Kalle2",
                            LastName = "Anka"
                        },
                        new
                        {
                            Id = 3,
                            Avatar = "123",
                            FirstName = "Kalle3",
                            LastName = "Anka"
                        });
                });

            modelBuilder.Entity("University.API.Models.Entities.Address", b =>
                {
                    b.HasOne("University.API.Models.Entities.Student", "Student")
                        .WithOne("Address")
                        .HasForeignKey("University.API.Models.Entities.Address", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("University.API.Models.Entities.Student", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
