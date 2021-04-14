﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentIncidents1.Data;

namespace StudentIncidents1.Migrations
{
    [DbContext(typeof(StudentIncidents1Context))]
    [Migration("20210414035444_initial-create2")]
    partial class initialcreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentIncidents.Models.Incident", b =>
                {
                    b.Property<int>("IncidentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IncidentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IncidentID");

                    b.ToTable("Incident");
                });

            modelBuilder.Entity("StudentIncidents.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("StudentIncidents1.Models.StudentIncident", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("IncidentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("IncidentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentId", "IncidentId");

                    b.HasIndex("IncidentId");

                    b.ToTable("StudentIncident");
                });

            modelBuilder.Entity("StudentIncidents1.Models.StudentIncident", b =>
                {
                    b.HasOne("StudentIncidents.Models.Incident", "Incident")
                        .WithMany("StudentIncidents")
                        .HasForeignKey("IncidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentIncidents.Models.Student", "Student")
                        .WithMany("StudentIncidents")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
