﻿// <auto-generated />
using System;
using FamilyDataServer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FamilyDataServer.Migrations
{
    [DbContext(typeof(FamilyDBContext))]
    [Migration("20211111094532_update_interestes_model_class")]
    partial class update_interestes_model_class
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("FamilyDataServer.Models.Adult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EyeColor")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FamilyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HairColor")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("JobTitleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.HasIndex("JobTitleId");

                    b.ToTable("Adults");
                });

            modelBuilder.Entity("FamilyDataServer.Models.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EyeColor")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FamilyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HairColor")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.ToTable("Children");
                });

            modelBuilder.Entity("FamilyDataServer.Models.Family", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StreetName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("FamilyDataServer.Models.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChildId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.ToTable("Interest");
                });

            modelBuilder.Entity("FamilyDataServer.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<int>("Salary")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("FamilyDataServer.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChildId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FamilyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Species")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.HasIndex("FamilyId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("FamilyDataServer.Models.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FamilyDataServer.Models.Adult", b =>
                {
                    b.HasOne("FamilyDataServer.Models.Family", null)
                        .WithMany("Adults")
                        .HasForeignKey("FamilyId");

                    b.HasOne("FamilyDataServer.Models.Job", "JobTitle")
                        .WithMany("Adults")
                        .HasForeignKey("JobTitleId");

                    b.Navigation("JobTitle");
                });

            modelBuilder.Entity("FamilyDataServer.Models.Child", b =>
                {
                    b.HasOne("FamilyDataServer.Models.Family", null)
                        .WithMany("Children")
                        .HasForeignKey("FamilyId");
                });

            modelBuilder.Entity("FamilyDataServer.Models.Interest", b =>
                {
                    b.HasOne("FamilyDataServer.Models.Child", null)
                        .WithMany("Interests")
                        .HasForeignKey("ChildId");
                });

            modelBuilder.Entity("FamilyDataServer.Models.Pet", b =>
                {
                    b.HasOne("FamilyDataServer.Models.Child", null)
                        .WithMany("Pets")
                        .HasForeignKey("ChildId");

                    b.HasOne("FamilyDataServer.Models.Family", null)
                        .WithMany("Pets")
                        .HasForeignKey("FamilyId");
                });

            modelBuilder.Entity("FamilyDataServer.Models.Child", b =>
                {
                    b.Navigation("Interests");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("FamilyDataServer.Models.Family", b =>
                {
                    b.Navigation("Adults");

                    b.Navigation("Children");

                    b.Navigation("Pets");
                });

            modelBuilder.Entity("FamilyDataServer.Models.Job", b =>
                {
                    b.Navigation("Adults");
                });
#pragma warning restore 612, 618
        }
    }
}
