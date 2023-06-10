﻿// <auto-generated />
using System;
using MVCDay2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCDay2.Migrations
{
    [DbContext(typeof(ITIEntity))]
    [Migration("20230607122742_v7")]
    partial class v7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCDay2.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int?>("Dept_id")
                        .HasColumnType("int");

                    b.Property<int>("Min_degree")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Dept_id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("MVCDay2.Models.CrsResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CrsId")
                        .HasColumnType("int");

                    b.Property<int?>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("TraineeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CrsId");

                    b.HasIndex("TraineeId");

                    b.ToTable("CourseResults");
                });

            modelBuilder.Entity("MVCDay2.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("MVCDay2.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Crs_id")
                        .HasColumnType("int");

                    b.Property<int?>("Dept_id")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Crs_id");

                    b.HasIndex("Dept_id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("MVCDay2.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dept_id")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Dept_id");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("MVCDay2.Models.Course", b =>
                {
                    b.HasOne("MVCDay2.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("Dept_id");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MVCDay2.Models.CrsResult", b =>
                {
                    b.HasOne("MVCDay2.Models.Course", "Course")
                        .WithMany("CrsResult")
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCDay2.Models.Trainee", "Trainee")
                        .WithMany()
                        .HasForeignKey("TraineeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("MVCDay2.Models.Instructor", b =>
                {
                    b.HasOne("MVCDay2.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("Crs_id");

                    b.HasOne("MVCDay2.Models.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("Dept_id");

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MVCDay2.Models.Trainee", b =>
                {
                    b.HasOne("MVCDay2.Models.Department", "Department")
                        .WithMany("Trainees")
                        .HasForeignKey("Dept_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MVCDay2.Models.Course", b =>
                {
                    b.Navigation("CrsResult");
                });

            modelBuilder.Entity("MVCDay2.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Instructors");

                    b.Navigation("Trainees");
                });
#pragma warning restore 612, 618
        }
    }
}
