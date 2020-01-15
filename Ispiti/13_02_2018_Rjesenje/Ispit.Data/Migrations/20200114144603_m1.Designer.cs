﻿// <auto-generated />
using Ispit.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Ispit.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200114144603_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ispit.Data.EntityModels.AutorizacijskiToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IpAdresa");

                    b.Property<int>("KorisnickiNalogId");

                    b.Property<string>("Vrijednost");

                    b.Property<DateTime>("VrijemeEvidentiranja");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("AutorizacijskiToken");
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.Dogadjaj", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumOdrzavanja");

                    b.Property<int?>("NastavnikID");

                    b.Property<string>("Opis");

                    b.HasKey("ID");

                    b.HasIndex("NastavnikID");

                    b.ToTable("Dogadjaj");
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.KorisnickiNalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("KorisnickoIme");

                    b.HasKey("Id");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.Nastavnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImePrezime");

                    b.Property<int>("KorisnickiNalogId");

                    b.HasKey("ID");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("Nastavnik");
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.Obaveza", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DogadjajID");

                    b.Property<string>("Naziv");

                    b.Property<int>("NotifikacijaDanaPrijeDefault");

                    b.Property<bool>("NotifikacijeRekurizivnoDefault");

                    b.HasKey("ID");

                    b.HasIndex("DogadjajID");

                    b.ToTable("Obaveza");
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.OznacenDogadjaj", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumDodavanja");

                    b.Property<int>("DogadjajID");

                    b.Property<int>("StudentID");

                    b.HasKey("ID");

                    b.HasIndex("DogadjajID");

                    b.HasIndex("StudentID");

                    b.ToTable("OznacenDogadjaj");
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.PoslataNotifikacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumSlanja");

                    b.Property<int>("StanjeObavezeID");

                    b.HasKey("Id");

                    b.HasIndex("StanjeObavezeID");

                    b.ToTable("PoslataNotifikacija");
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.StanjeObaveze", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumIzvrsenja");

                    b.Property<bool>("IsZavrseno");

                    b.Property<float>("IzvrsenoProcentualno");

                    b.Property<int>("NotifikacijaDanaPrije");

                    b.Property<bool>("NotifikacijeRekurizivno");

                    b.Property<int>("ObavezaID");

                    b.Property<int>("OznacenDogadjajID");

                    b.HasKey("Id");

                    b.HasIndex("ObavezaID");

                    b.HasIndex("OznacenDogadjajID");

                    b.ToTable("StanjeObaveze");
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImePrezime");

                    b.Property<int>("KorisnickiNalogId");

                    b.HasKey("ID");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.AutorizacijskiToken", b =>
                {
                    b.HasOne("Ispit.Data.EntityModels.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.Dogadjaj", b =>
                {
                    b.HasOne("Ispit.Data.EntityModels.Nastavnik", "Nastavnik")
                        .WithMany()
                        .HasForeignKey("NastavnikID");
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.Nastavnik", b =>
                {
                    b.HasOne("Ispit.Data.EntityModels.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.Obaveza", b =>
                {
                    b.HasOne("Ispit.Data.EntityModels.Dogadjaj", "Dogadjaj")
                        .WithMany()
                        .HasForeignKey("DogadjajID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.OznacenDogadjaj", b =>
                {
                    b.HasOne("Ispit.Data.EntityModels.Dogadjaj", "Dogadjaj")
                        .WithMany()
                        .HasForeignKey("DogadjajID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ispit.Data.EntityModels.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.PoslataNotifikacija", b =>
                {
                    b.HasOne("Ispit.Data.EntityModels.StanjeObaveze", "StanjeObaveze")
                        .WithMany()
                        .HasForeignKey("StanjeObavezeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.StanjeObaveze", b =>
                {
                    b.HasOne("Ispit.Data.EntityModels.Obaveza", "Obaveza")
                        .WithMany()
                        .HasForeignKey("ObavezaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ispit.Data.EntityModels.OznacenDogadjaj", "OznacenDogadjaj")
                        .WithMany()
                        .HasForeignKey("OznacenDogadjajID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Ispit.Data.EntityModels.Student", b =>
                {
                    b.HasOne("Ispit.Data.EntityModels.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
