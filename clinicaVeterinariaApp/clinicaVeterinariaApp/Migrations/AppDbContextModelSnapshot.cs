﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using clinicaVeterinariaApp.Data;

#nullable disable

namespace clinicaVeterinariaApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Armadio", b =>
                {
                    b.Property<int>("ArmadioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArmadioID"));

                    b.Property<string>("CodiceUnivoco")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ArmadioID");

                    b.ToTable("Armadi");

                    b.HasData(
                        new
                        {
                            ArmadioID = 1,
                            CodiceUnivoco = "AR001"
                        },
                        new
                        {
                            ArmadioID = 2,
                            CodiceUnivoco = "AR002"
                        },
                        new
                        {
                            ArmadioID = 3,
                            CodiceUnivoco = "AR003"
                        },
                        new
                        {
                            ArmadioID = 4,
                            CodiceUnivoco = "AR004"
                        },
                        new
                        {
                            ArmadioID = 5,
                            CodiceUnivoco = "AR005"
                        });
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Cassetto", b =>
                {
                    b.Property<int>("CassettoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CassettoID"));

                    b.Property<int>("ArmadioID")
                        .HasColumnType("int");

                    b.Property<int>("NumeroCassetto")
                        .HasColumnType("int");

                    b.HasKey("CassettoID");

                    b.HasIndex("ArmadioID");

                    b.ToTable("Cassetto");

                    b.HasData(
                        new
                        {
                            CassettoID = 1,
                            ArmadioID = 1,
                            NumeroCassetto = 1
                        },
                        new
                        {
                            CassettoID = 2,
                            ArmadioID = 1,
                            NumeroCassetto = 2
                        },
                        new
                        {
                            CassettoID = 3,
                            ArmadioID = 1,
                            NumeroCassetto = 3
                        },
                        new
                        {
                            CassettoID = 4,
                            ArmadioID = 1,
                            NumeroCassetto = 4
                        },
                        new
                        {
                            CassettoID = 5,
                            ArmadioID = 1,
                            NumeroCassetto = 5
                        },
                        new
                        {
                            CassettoID = 6,
                            ArmadioID = 1,
                            NumeroCassetto = 6
                        },
                        new
                        {
                            CassettoID = 7,
                            ArmadioID = 1,
                            NumeroCassetto = 7
                        },
                        new
                        {
                            CassettoID = 8,
                            ArmadioID = 1,
                            NumeroCassetto = 8
                        },
                        new
                        {
                            CassettoID = 9,
                            ArmadioID = 2,
                            NumeroCassetto = 1
                        },
                        new
                        {
                            CassettoID = 10,
                            ArmadioID = 2,
                            NumeroCassetto = 2
                        },
                        new
                        {
                            CassettoID = 11,
                            ArmadioID = 2,
                            NumeroCassetto = 3
                        },
                        new
                        {
                            CassettoID = 12,
                            ArmadioID = 2,
                            NumeroCassetto = 4
                        },
                        new
                        {
                            CassettoID = 13,
                            ArmadioID = 2,
                            NumeroCassetto = 5
                        },
                        new
                        {
                            CassettoID = 14,
                            ArmadioID = 2,
                            NumeroCassetto = 6
                        },
                        new
                        {
                            CassettoID = 15,
                            ArmadioID = 2,
                            NumeroCassetto = 7
                        },
                        new
                        {
                            CassettoID = 16,
                            ArmadioID = 2,
                            NumeroCassetto = 8
                        },
                        new
                        {
                            CassettoID = 17,
                            ArmadioID = 3,
                            NumeroCassetto = 1
                        },
                        new
                        {
                            CassettoID = 18,
                            ArmadioID = 3,
                            NumeroCassetto = 2
                        },
                        new
                        {
                            CassettoID = 19,
                            ArmadioID = 3,
                            NumeroCassetto = 3
                        },
                        new
                        {
                            CassettoID = 20,
                            ArmadioID = 3,
                            NumeroCassetto = 4
                        },
                        new
                        {
                            CassettoID = 21,
                            ArmadioID = 3,
                            NumeroCassetto = 5
                        },
                        new
                        {
                            CassettoID = 22,
                            ArmadioID = 3,
                            NumeroCassetto = 6
                        },
                        new
                        {
                            CassettoID = 23,
                            ArmadioID = 3,
                            NumeroCassetto = 7
                        },
                        new
                        {
                            CassettoID = 24,
                            ArmadioID = 3,
                            NumeroCassetto = 8
                        },
                        new
                        {
                            CassettoID = 25,
                            ArmadioID = 4,
                            NumeroCassetto = 1
                        },
                        new
                        {
                            CassettoID = 26,
                            ArmadioID = 4,
                            NumeroCassetto = 2
                        },
                        new
                        {
                            CassettoID = 27,
                            ArmadioID = 4,
                            NumeroCassetto = 3
                        },
                        new
                        {
                            CassettoID = 28,
                            ArmadioID = 4,
                            NumeroCassetto = 4
                        },
                        new
                        {
                            CassettoID = 29,
                            ArmadioID = 4,
                            NumeroCassetto = 5
                        },
                        new
                        {
                            CassettoID = 30,
                            ArmadioID = 4,
                            NumeroCassetto = 6
                        },
                        new
                        {
                            CassettoID = 31,
                            ArmadioID = 4,
                            NumeroCassetto = 7
                        },
                        new
                        {
                            CassettoID = 32,
                            ArmadioID = 4,
                            NumeroCassetto = 8
                        },
                        new
                        {
                            CassettoID = 33,
                            ArmadioID = 5,
                            NumeroCassetto = 1
                        },
                        new
                        {
                            CassettoID = 34,
                            ArmadioID = 5,
                            NumeroCassetto = 2
                        },
                        new
                        {
                            CassettoID = 35,
                            ArmadioID = 5,
                            NumeroCassetto = 3
                        },
                        new
                        {
                            CassettoID = 36,
                            ArmadioID = 5,
                            NumeroCassetto = 4
                        },
                        new
                        {
                            CassettoID = 37,
                            ArmadioID = 5,
                            NumeroCassetto = 5
                        },
                        new
                        {
                            CassettoID = 38,
                            ArmadioID = 5,
                            NumeroCassetto = 6
                        },
                        new
                        {
                            CassettoID = 39,
                            ArmadioID = 5,
                            NumeroCassetto = 7
                        },
                        new
                        {
                            CassettoID = 40,
                            ArmadioID = 5,
                            NumeroCassetto = 8
                        });
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteID"));

                    b.Property<string>("CodiceFiscale")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Indirizzo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ClienteID");

                    b.HasIndex("CodiceFiscale")
                        .IsUnique();

                    b.ToTable("Clienti");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Fornitore", b =>
                {
                    b.Property<int>("FornitoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FornitoreId"));

                    b.Property<string>("Indirizzo")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Recapito")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("FornitoreId");

                    b.ToTable("Fornitori");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Medicinale", b =>
                {
                    b.Property<int>("MedicinaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicinaleID"));

                    b.Property<int>("CassettoID")
                        .HasColumnType("int");

                    b.Property<int>("ProdottoID")
                        .HasColumnType("int");

                    b.HasKey("MedicinaleID");

                    b.HasIndex("CassettoID");

                    b.HasIndex("ProdottoID");

                    b.ToTable("Medicinali");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Prodotto", b =>
                {
                    b.Property<int>("ProdottoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdottoID"));

                    b.Property<string>("ElencoUsi")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("FornitoreId")
                        .HasColumnType("int");

                    b.Property<string>("FotoProdotto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("PrezzoUnitario")
                        .HasMaxLength(20)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ProdottoID");

                    b.HasIndex("FornitoreId");

                    b.ToTable("Prodotti");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Vendita", b =>
                {
                    b.Property<int>("VenditaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VenditaID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataVendita")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeroRicettaMedica")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProdottoID")
                        .HasColumnType("int");

                    b.Property<int>("Quantita")
                        .HasColumnType("int");

                    b.Property<bool>("StatoVendita")
                        .HasColumnType("bit");

                    b.HasKey("VenditaID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("ProdottoID");

                    b.ToTable("Vendite");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Animali", b =>
                {
                    b.Property<int>("AnimaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimaleID"));

                    b.Property<string>("ColoreMantello")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("DataNascita")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Dataregistrazione")
                        .HasColumnType("datetime2");

                    b.Property<string>("FotoAnimale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MicrochipBit")
                        .HasColumnType("bit");

                    b.Property<string>("MicrochipNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeAnimale")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProprietarioID")
                        .HasColumnType("int");

                    b.Property<string>("Tipologia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AnimaleID");

                    b.HasIndex("ProprietarioID");

                    b.ToTable("Animali");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.ContabilizzazioneRicoveri", b =>
                {
                    b.Property<int>("ContabilizzazioneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContabilizzazioneID"));

                    b.Property<DateTime>("DataContabilizzazione")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Importo")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("RicoveroID")
                        .HasColumnType("int");

                    b.HasKey("ContabilizzazioneID");

                    b.HasIndex("RicoveroID");

                    b.ToTable("ContabilizzazioneRicoveri");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Proprietario", b =>
                {
                    b.Property<int>("ProprietarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProprietarioID"));

                    b.Property<string>("Codicefiscale")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cognome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DataNascita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PrenotazioneToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ProprietarioID");

                    b.HasIndex("Codicefiscale")
                        .IsUnique();

                    b.HasIndex("UserID")
                        .IsUnique()
                        .HasFilter("[UserID] IS NOT NULL");

                    b.ToTable("Proprietari");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Ricoveri", b =>
                {
                    b.Property<int>("RicoveriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RicoveriID"));

                    b.Property<int>("AnimaleID")
                        .HasColumnType("int");

                    b.Property<bool>("Attivo")
                        .HasColumnType("bit");

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("DataFineRicovero")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datainizioricovero")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tipologia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RicoveriID");

                    b.HasIndex("AnimaleID");

                    b.ToTable("Ricoveri");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Ruoli", b =>
                {
                    b.Property<int>("RuoloID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RuoloID"));

                    b.Property<string>("NomeRuolo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RuoloID");

                    b.ToTable("Ruoli");

                    b.HasData(
                        new
                        {
                            RuoloID = 1,
                            NomeRuolo = "Veterinario"
                        },
                        new
                        {
                            RuoloID = 2,
                            NomeRuolo = "Farmacista"
                        },
                        new
                        {
                            RuoloID = 3,
                            NomeRuolo = "User"
                        });
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Users", b =>
                {
                    b.Property<int>("UsersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsersID"));

                    b.Property<string>("CognomeUser")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NomeUser")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("RuoloID")
                        .HasColumnType("int");

                    b.HasKey("UsersID");

                    b.HasIndex("RuoloID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Visite", b =>
                {
                    b.Property<int>("VisitaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitaID"));

                    b.Property<int>("AnimaleID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataVisita")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescrizioneCura")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EsameObiettivo")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("VisitaID");

                    b.HasIndex("AnimaleID");

                    b.ToTable("Visite");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Cassetto", b =>
                {
                    b.HasOne("clinicaVeterinariaApp.Models.Farmacia.Armadio", "Armadio")
                        .WithMany("Cassetto")
                        .HasForeignKey("ArmadioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Armadio");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Medicinale", b =>
                {
                    b.HasOne("clinicaVeterinariaApp.Models.Farmacia.Cassetto", "Cassetto")
                        .WithMany("Medicinale")
                        .HasForeignKey("CassettoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("clinicaVeterinariaApp.Models.Farmacia.Prodotto", "Prodotto")
                        .WithMany("Medicinale")
                        .HasForeignKey("ProdottoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cassetto");

                    b.Navigation("Prodotto");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Prodotto", b =>
                {
                    b.HasOne("clinicaVeterinariaApp.Models.Farmacia.Fornitore", "Fornitore")
                        .WithMany("Prodotti")
                        .HasForeignKey("FornitoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornitore");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Vendita", b =>
                {
                    b.HasOne("clinicaVeterinariaApp.Models.Farmacia.Cliente", "Cliente")
                        .WithMany("Vendita")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("clinicaVeterinariaApp.Models.Farmacia.Prodotto", "Prodotto")
                        .WithMany("Vendita")
                        .HasForeignKey("ProdottoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Prodotto");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Animali", b =>
                {
                    b.HasOne("clinicaVeterinariaApp.Models.Veterinario.Proprietario", "Proprietario")
                        .WithMany("Animali")
                        .HasForeignKey("ProprietarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proprietario");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.ContabilizzazioneRicoveri", b =>
                {
                    b.HasOne("clinicaVeterinariaApp.Models.Veterinario.Ricoveri", "Ricoveri")
                        .WithMany("ContabilizzazioneRicoveri")
                        .HasForeignKey("RicoveroID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ricoveri");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Proprietario", b =>
                {
                    b.HasOne("clinicaVeterinariaApp.Models.Veterinario.Users", "User")
                        .WithOne()
                        .HasForeignKey("clinicaVeterinariaApp.Models.Veterinario.Proprietario", "UserID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("User");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Ricoveri", b =>
                {
                    b.HasOne("clinicaVeterinariaApp.Models.Veterinario.Animali", "Animali")
                        .WithMany("Ricoveri")
                        .HasForeignKey("AnimaleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animali");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Users", b =>
                {
                    b.HasOne("clinicaVeterinariaApp.Models.Veterinario.Ruoli", "Ruoli")
                        .WithMany("Users")
                        .HasForeignKey("RuoloID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ruoli");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Visite", b =>
                {
                    b.HasOne("clinicaVeterinariaApp.Models.Veterinario.Animali", "Animale")
                        .WithMany("Visite")
                        .HasForeignKey("AnimaleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animale");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Armadio", b =>
                {
                    b.Navigation("Cassetto");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Cassetto", b =>
                {
                    b.Navigation("Medicinale");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Cliente", b =>
                {
                    b.Navigation("Vendita");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Fornitore", b =>
                {
                    b.Navigation("Prodotti");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Farmacia.Prodotto", b =>
                {
                    b.Navigation("Medicinale");

                    b.Navigation("Vendita");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Animali", b =>
                {
                    b.Navigation("Ricoveri");

                    b.Navigation("Visite");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Proprietario", b =>
                {
                    b.Navigation("Animali");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Ricoveri", b =>
                {
                    b.Navigation("ContabilizzazioneRicoveri");
                });

            modelBuilder.Entity("clinicaVeterinariaApp.Models.Veterinario.Ruoli", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
