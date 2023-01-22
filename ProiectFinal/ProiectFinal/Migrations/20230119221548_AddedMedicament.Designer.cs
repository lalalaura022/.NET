﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectFinal.data;

namespace ProiectFinal.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230119221548_AddedMedicament")]
    partial class AddedMedicament
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProiectFinal.Entities.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Denumire")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("ProiectFinal.Entitiestb.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IngrijitorId")
                        .HasColumnType("int");

                    b.Property<int>("Numar")
                        .HasColumnType("int");

                    b.Property<string>("Oras")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Strada")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IngrijitorId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("ProiectFinal.Entitiestb.AnimalMedicament", b =>
                {
                    b.Property<int>("MedicamentId")
                        .HasColumnType("int");

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.HasKey("MedicamentId", "AnimalId");

                    b.HasIndex("AnimalId");

                    b.ToTable("AnimalMedicamente");
                });

            modelBuilder.Entity("ProiectFinal.Entitiestb.Ingrijitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnAngajare")
                        .HasColumnType("int");

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("Inrijitori");
                });

            modelBuilder.Entity("ProiectFinal.Entitiestb.Medicament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Denumire")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gramaj")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Medicament");
                });

            modelBuilder.Entity("ProiectFinal.Entitiestb.Address", b =>
                {
                    b.HasOne("ProiectFinal.Entitiestb.Ingrijitor", "Ingrijitor")
                        .WithOne("Address")
                        .HasForeignKey("ProiectFinal.Entitiestb.Address", "IngrijitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingrijitor");
                });

            modelBuilder.Entity("ProiectFinal.Entitiestb.AnimalMedicament", b =>
                {
                    b.HasOne("ProiectFinal.Entities.Animal", "Animal")
                        .WithMany("AnimalMedicamente")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProiectFinal.Entitiestb.Medicament", "Medicament")
                        .WithMany("AnimalMedicamente")
                        .HasForeignKey("MedicamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Medicament");
                });

            modelBuilder.Entity("ProiectFinal.Entitiestb.Ingrijitor", b =>
                {
                    b.HasOne("ProiectFinal.Entities.Animal", "Animal")
                        .WithMany("Ingrijitori")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("ProiectFinal.Entities.Animal", b =>
                {
                    b.Navigation("AnimalMedicamente");

                    b.Navigation("Ingrijitori");
                });

            modelBuilder.Entity("ProiectFinal.Entitiestb.Ingrijitor", b =>
                {
                    b.Navigation("Address");
                });

            modelBuilder.Entity("ProiectFinal.Entitiestb.Medicament", b =>
                {
                    b.Navigation("AnimalMedicamente");
                });
#pragma warning restore 612, 618
        }
    }
}