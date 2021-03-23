﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using finly.Data;

namespace finly.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210323161142_AddExtraClientModelsAndMortgage")]
    partial class AddExtraClientModelsAndMortgage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("finly.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NationalInsuranceNumber")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PreferredName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<int?>("SmokerStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SmokingQuitDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("finly.Models.ClientMarketingConsent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ClientConsentedDirectly")
                        .HasColumnType("bit");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ConsentGivenDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ConsentRetractedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ConsentType")
                        .HasColumnType("int");

                    b.Property<string>("HowWasConsentObtained")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientMarketingConsents");
                });

            modelBuilder.Entity("finly.Models.ClientPreviousName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfNameChange")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Title")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("ClientPreviousNames");
                });

            modelBuilder.Entity("finly.Models.CompanyClient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyNumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("CompanyType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("IncorporationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<string>("RegisteredCompanyName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("CompanyClients");
                });

            modelBuilder.Entity("finly.Models.CompanyClientSICCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyClientId")
                        .HasColumnType("int");

                    b.Property<string>("SICCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyClientId");

                    b.ToTable("CompanyClientSICCodes");
                });

            modelBuilder.Entity("finly.Models.Mortgage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyClientId")
                        .HasColumnType("int");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyClientId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Mortgages");
                });

            modelBuilder.Entity("finly.Models.MortgageClient", b =>
                {
                    b.Property<int>("MortgageId")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.HasKey("MortgageId", "ClientId");

                    b.HasIndex("ClientId");

                    b.ToTable("MortgageClient");
                });

            modelBuilder.Entity("finly.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("finly.Models.Client", b =>
                {
                    b.HasOne("finly.Models.Profile", "Profile")
                        .WithMany("Clients")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("finly.Models.ClientMarketingConsent", b =>
                {
                    b.HasOne("finly.Models.Client", "Client")
                        .WithMany("ClientMarketingConsents")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("finly.Models.ClientPreviousName", b =>
                {
                    b.HasOne("finly.Models.Client", "Client")
                        .WithMany("PreviousNames")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("finly.Models.CompanyClient", b =>
                {
                    b.HasOne("finly.Models.Profile", "Profile")
                        .WithMany("CompanyClients")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("finly.Models.CompanyClientSICCode", b =>
                {
                    b.HasOne("finly.Models.CompanyClient", "CompanyClient")
                        .WithMany("CompanyClientSICCodes")
                        .HasForeignKey("CompanyClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyClient");
                });

            modelBuilder.Entity("finly.Models.Mortgage", b =>
                {
                    b.HasOne("finly.Models.CompanyClient", "CompanyClient")
                        .WithMany("Mortgages")
                        .HasForeignKey("CompanyClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("finly.Models.Profile", "Profile")
                        .WithMany("Mortgages")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CompanyClient");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("finly.Models.MortgageClient", b =>
                {
                    b.HasOne("finly.Models.Client", "Client")
                        .WithMany("MortgageClients")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("finly.Models.Mortgage", "Mortgage")
                        .WithMany("MortgageClients")
                        .HasForeignKey("MortgageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Mortgage");
                });

            modelBuilder.Entity("finly.Models.Client", b =>
                {
                    b.Navigation("ClientMarketingConsents");

                    b.Navigation("MortgageClients");

                    b.Navigation("PreviousNames");
                });

            modelBuilder.Entity("finly.Models.CompanyClient", b =>
                {
                    b.Navigation("CompanyClientSICCodes");

                    b.Navigation("Mortgages");
                });

            modelBuilder.Entity("finly.Models.Mortgage", b =>
                {
                    b.Navigation("MortgageClients");
                });

            modelBuilder.Entity("finly.Models.Profile", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("CompanyClients");

                    b.Navigation("Mortgages");
                });
#pragma warning restore 612, 618
        }
    }
}
