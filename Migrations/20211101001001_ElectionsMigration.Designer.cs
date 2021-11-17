﻿// <auto-generated />
using Elections.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Elections.Migrations
{
    [DbContext(typeof(ElectionsContext))]
    [Migration("20211101001001_ElectionsMigration")]
    partial class ElectionsMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Elections.IecParties", b =>
                {
                    b.Property<string>("PartyName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Leader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartyAbbr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PartyName");

                    b.ToTable("NovElections");
                });
#pragma warning restore 612, 618
        }
    }
}