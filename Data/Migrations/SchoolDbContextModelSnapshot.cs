﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerBlazorEF.Data;

#nullable disable

namespace ServerBlazorEF.Data.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("ServerBlazorEF.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            ConfirmPassword = "password1",
                            FirstName = "Tom",
                            LastName = "Max",
                            Password = "password1",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 2,
                            ConfirmPassword = "password2",
                            FirstName = "Ann",
                            LastName = "Fay",
                            Password = "password2",
                            School = "Mining"
                        },
                        new
                        {
                            StudentId = 3,
                            ConfirmPassword = "password3",
                            FirstName = "Joe",
                            LastName = "Sun",
                            Password = "password3",
                            School = "Nursing"
                        },
                        new
                        {
                            StudentId = 4,
                            ConfirmPassword = "password4",
                            FirstName = "Sue",
                            LastName = "Fox",
                            Password = "password4",
                            School = "Computing"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
