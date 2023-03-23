﻿// <auto-generated />
using System;
using Console_Management_of_medical_clinic.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Console_Management_of_medical_clinic.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230323141540_test3")]
    partial class test3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.EmployeeModel", b =>
                {
                    b.Property<int>("IdEmployee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CorrespondenceAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("IdSpecialization1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUser")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PESEL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sex")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdEmployee");

                    b.HasIndex("IdSpecialization1");

                    b.HasIndex("IdUser")
                        .IsUnique();

                    b.ToTable("DbEmployees");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.SpecializationModel", b =>
                {
                    b.Property<int>("IdSpecialization")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdSpecialization");

                    b.ToTable("DbSpecializations");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.UserModel", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdUser");

                    b.ToTable("DbUsers");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.EmployeeModel", b =>
                {
                    b.HasOne("Console_Management_of_medical_clinic.Model.SpecializationModel", "IdSpecialization")
                        .WithMany()
                        .HasForeignKey("IdSpecialization1");

                    b.HasOne("Console_Management_of_medical_clinic.Model.UserModel", "UserModel")
                        .WithOne("EmployeeModle")
                        .HasForeignKey("Console_Management_of_medical_clinic.Model.EmployeeModel", "IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdSpecialization");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("Console_Management_of_medical_clinic.Model.UserModel", b =>
                {
                    b.Navigation("EmployeeModle")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
