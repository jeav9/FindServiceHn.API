﻿// <auto-generated />
using System;
using FindServiceHn.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FindServiceHn.Database.Migrations
{
    [DbContext(typeof(FindServiceHnContext))]
    [Migration("20220819044226_New models")]
    partial class Newmodels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FindServiceHn.Database.Models.Category", b =>
                {
                    b.Property<int>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdStatus")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdCategory");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FindServiceHn.Database.Models.Order_detail", b =>
                {
                    b.Property<int>("IdOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int>("IdProvider")
                        .HasColumnType("int");

                    b.Property<int>("IdStatus")
                        .HasColumnType("int");

                    b.Property<string>("Line")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("IdOrder");

                    b.ToTable("Order_Details");
                });

            modelBuilder.Entity("FindServiceHn.Database.Models.Order_satisfaction", b =>
                {
                    b.Property<int>("IdSatisfaction")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Valorization")
                        .HasColumnType("int");

                    b.HasKey("IdSatisfaction");

                    b.ToTable("Order_satisfactions");
                });

            modelBuilder.Entity("FindServiceHn.Database.Models.Order_status", b =>
                {
                    b.Property<int>("IdStatusOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdStatus")
                        .HasColumnType("int");

                    b.HasKey("IdStatusOrder");

                    b.ToTable("Order_status");
                });

            modelBuilder.Entity("FindServiceHn.Database.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FindServiceHn.Database.Models.Provider", b =>
                {
                    b.Property<int>("IdProvider")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AtentionFirst")
                        .HasColumnType("int");

                    b.Property<int>("AtentionLast")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdCategory")
                        .HasColumnType("int");

                    b.Property<int>("IdSubcategory")
                        .HasColumnType("int");

                    b.Property<int>("IdentificationCard")
                        .HasColumnType("int");

                    b.Property<int>("IndDelivery")
                        .HasColumnType("int");

                    b.Property<int>("IndusCai")
                        .HasColumnType("int");

                    b.Property<int>("KeyValidation")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Municipality")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProfilePrincipal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("QtyWorks")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RTN")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdProvider");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("FindServiceHn.Database.Models.ProviderEval", b =>
                {
                    b.Property<int>("IdEval")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Idcategory")
                        .HasColumnType("int");

                    b.Property<int>("Istatus")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("IdEval");

                    b.ToTable("provider_Evals");
                });

            modelBuilder.Entity("FindServiceHn.Database.Models.ProviderPlanJob", b =>
                {
                    b.Property<int>("IdQtyWorks")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CreationDate")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdQtyWorks");

                    b.ToTable("Provider_Plan_Jobs");
                });

            modelBuilder.Entity("FindServiceHn.Database.Models.ProvidersAttention", b =>
                {
                    b.Property<int>("IdProviderAttention")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IStatus")
                        .HasColumnType("int");

                    b.Property<string>("TypeAttention")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdProviderAttention");

                    b.ToTable("ProvidersAttentions");
                });

            modelBuilder.Entity("FindServiceHn.Database.Models.ProviderService", b =>
                {
                    b.Property<int>("IdProviderService")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdServiceType")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Shipping")
                        .HasColumnType("int");

                    b.Property<string>("TypeService")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdProviderService");

                    b.ToTable("Provider_Services");
                });

            modelBuilder.Entity("FindServiceHn.Database.Models.QuotesDetail", b =>
                {
                    b.Property<int>("IdQuoteDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("IStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int>("IdProvider")
                        .HasColumnType("int");

                    b.Property<string>("Line")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("IdQuoteDetail");

                    b.ToTable("QuotesDetails");
                });

            modelBuilder.Entity("FindServiceHn.Database.Models.QuotesHeader", b =>
                {
                    b.Property<int>("IdQuoteHeader")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AssigmentDate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CustomerObservation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("IStatus")
                        .HasColumnType("int");

                    b.Property<int>("IStatusCreationDate")
                        .HasColumnType("int");

                    b.Property<int>("IdCate")
                        .HasColumnType("int");

                    b.Property<int>("IdClientAddres")
                        .HasColumnType("int");

                    b.Property<int>("IdCustomer")
                        .HasColumnType("int");

                    b.Property<int>("IdProvider")
                        .HasColumnType("int");

                    b.Property<int>("IdQuoteDetail")
                        .HasColumnType("int");

                    b.Property<int>("IdSubcategory")
                        .HasColumnType("int");

                    b.Property<string>("ProviderObservation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdQuoteHeader");

                    b.ToTable("QuotesHeaders");
                });

            modelBuilder.Entity("FindServiceHn.Database.Models.ServicesStatus", b =>
                {
                    b.Property<int>("IdServicesStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IStatus")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdServicesStatus");

                    b.ToTable("ServicesStatuss");
                });

            modelBuilder.Entity("FindServiceHn.Database.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
