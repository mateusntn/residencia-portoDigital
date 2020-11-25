﻿// <auto-generated />
using Dinda.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dinda.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201125022030_TabelaMadrinhas")]
    partial class TabelaMadrinhas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dinda.Models.Conhecimentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Conhecimentos");
                });

            modelBuilder.Entity("Dinda.Models.Madrinhas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConhecimentosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConhecimentosId");

                    b.ToTable("Madrinhas");
                });

            modelBuilder.Entity("Dinda.Models.Madrinhas", b =>
                {
                    b.HasOne("Dinda.Models.Conhecimentos", "Conhecimentos")
                        .WithMany("Madrinhas")
                        .HasForeignKey("ConhecimentosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}