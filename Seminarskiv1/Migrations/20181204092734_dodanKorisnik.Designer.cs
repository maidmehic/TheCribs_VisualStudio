﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Seminarskiv1.EF;

namespace Seminarskiv1.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20181204092734_dodanKorisnik")]
    partial class dodanKorisnik
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Seminarskiv1.EntityModels.DetaljiStana", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<string>("BrojSoba");

                    b.Property<string>("Opis");

                    b.Property<int>("StanId");

                    b.HasKey("Id");

                    b.HasIndex("StanId");

                    b.ToTable("DetaljiStana");
                });

            modelBuilder.Entity("Seminarskiv1.EntityModels.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("Seminarskiv1.EntityModels.Kategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("Seminarskiv1.EntityModels.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Ime");

                    b.Property<string>("Password");

                    b.Property<string>("Prezime");

                    b.HasKey("Id");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("Seminarskiv1.EntityModels.Stan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena");

                    b.Property<DateTime>("DatumObjave");

                    b.Property<int>("GradId");

                    b.Property<int>("KategorijaId");

                    b.Property<string>("Naziv");

                    b.Property<byte[]>("Slika");

                    b.HasKey("Id");

                    b.HasIndex("GradId");

                    b.HasIndex("KategorijaId");

                    b.ToTable("Stan");
                });

            modelBuilder.Entity("Seminarskiv1.EntityModels.ViseDetalja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Balkon");

                    b.Property<int>("DetaljiStanaId");

                    b.Property<string>("Email");

                    b.Property<string>("GodIzgradnje");

                    b.Property<bool>("Internet");

                    b.Property<bool>("Kablovska");

                    b.Property<bool>("Klima");

                    b.Property<bool>("Parking");

                    b.Property<string>("Telefon");

                    b.Property<string>("VrstaGrijanja");

                    b.Property<string>("VrstaPlacanja");

                    b.HasKey("Id");

                    b.HasIndex("DetaljiStanaId");

                    b.ToTable("ViseDetalja");
                });

            modelBuilder.Entity("Seminarskiv1.EntityModels.DetaljiStana", b =>
                {
                    b.HasOne("Seminarskiv1.EntityModels.Stan", "Stan")
                        .WithMany()
                        .HasForeignKey("StanId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Seminarskiv1.EntityModels.Stan", b =>
                {
                    b.HasOne("Seminarskiv1.EntityModels.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Seminarskiv1.EntityModels.Kategorija", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Seminarskiv1.EntityModels.ViseDetalja", b =>
                {
                    b.HasOne("Seminarskiv1.EntityModels.DetaljiStana", "DetaljiStana")
                        .WithMany()
                        .HasForeignKey("DetaljiStanaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
