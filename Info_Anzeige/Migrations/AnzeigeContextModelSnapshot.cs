﻿// <auto-generated />
using System;
using Info_Anzeige.Klassen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Info_Anzeige.Migrations
{
    [DbContext(typeof(AnzeigeContext))]
    partial class AnzeigeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Info_Anzeige.Klassen.Benutzer", b =>
                {
                    b.Property<long>("Benutzer_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Benutzer_ID"));

                    b.Property<string>("Berechtigung")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Passwort")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Benutzer_ID");

                    b.ToTable("Benutzer");

                    b.HasData(
                        new
                        {
                            Benutzer_ID = 1L,
                            Berechtigung = "Admin",
                            Name = "Admin",
                            Passwort = "0000"
                        });
                });

            modelBuilder.Entity("Info_Anzeige.Klassen.Post", b =>
                {
                    b.Property<long>("Post_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("Post_ID"));

                    b.Property<long>("Benutzer_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Erstellungs_Datum")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Sichtberkeit_Lehrer")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("Sichtberkeit_Schüler")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Post_ID");

                    b.HasIndex("Benutzer_ID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Info_Anzeige.Klassen.Post", b =>
                {
                    b.HasOne("Info_Anzeige.Klassen.Benutzer", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("Benutzer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Info_Anzeige.Klassen.Benutzer", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
