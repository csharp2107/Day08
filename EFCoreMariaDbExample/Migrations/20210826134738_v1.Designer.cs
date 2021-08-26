﻿// <auto-generated />
using System;
using EFCoreMariaDbExample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreMariaDbExample.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20210826134738_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("EFCoreMariaDbExample.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("EFCoreMariaDbExample.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("EmployeeID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EFCoreMariaDbExample.EmployeeAddress", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.HasKey("EmployeeID");

                    b.ToTable("EmployeeAddresses");
                });

            modelBuilder.Entity("EFCoreMariaDbExample.Employee", b =>
                {
                    b.HasOne("EFCoreMariaDbExample.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EFCoreMariaDbExample.EmployeeAddress", b =>
                {
                    b.HasOne("EFCoreMariaDbExample.Employee", "Employee")
                        .WithOne("EmployeeAddress")
                        .HasForeignKey("EFCoreMariaDbExample.EmployeeAddress", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EFCoreMariaDbExample.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EFCoreMariaDbExample.Employee", b =>
                {
                    b.Navigation("EmployeeAddress");
                });
#pragma warning restore 612, 618
        }
    }
}
