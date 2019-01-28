﻿// <auto-generated />
using System;
using DanLiris.Admin.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DanLiris.Admin.Web.Migrations
{
    [DbContext(typeof(AppStorageContext))]
    partial class AppStorageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Manufactures.Domain.Construction.Entities.ConstructionDetail", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ConstructionDocumentId");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("Detail");

                    b.Property<string>("Information");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<double>("Quantity");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Yarn")
                        .HasMaxLength(255);

                    b.HasKey("Identity");

                    b.HasIndex("ConstructionDocumentId");

                    b.ToTable("Weaving_ConstructionDetails");
                });

            modelBuilder.Entity("Manufactures.Domain.Construction.ReadModels.ConstructionDocumentReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AmountOfWarp");

                    b.Property<int>("AmountOfWeft");

                    b.Property<string>("ConstructionNumber")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<Guid>("MaterialType");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<double>("TotalYarn");

                    b.Property<string>("WarpType")
                        .HasMaxLength(255);

                    b.Property<string>("WeftType")
                        .HasMaxLength(255);

                    b.Property<int>("Width");

                    b.Property<string>("WovenType")
                        .HasMaxLength(255);

                    b.HasKey("Identity");

                    b.ToTable("Weaving_Constructions");
                });

            modelBuilder.Entity("Manufactures.Domain.Materials.ReadModels.MaterialTypeReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Identity");

                    b.ToTable("Weaving_MaterialTypes");
                });

            modelBuilder.Entity("Manufactures.Domain.Orders.ReadModels.WeavingOrderDocumentReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Composition")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<DateTimeOffset>("DateOrdered");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("FabricConstructionDocument")
                        .HasMaxLength(255);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("OrderNumber");

                    b.Property<string>("Period")
                        .HasMaxLength(255);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("WarpOrigin");

                    b.Property<string>("WeavingUnit")
                        .HasMaxLength(255);

                    b.Property<string>("WeftOrigin");

                    b.Property<int>("WholeGrade");

                    b.Property<string>("YarnType");

                    b.HasKey("Identity");

                    b.ToTable("Weaving_OrderDocuments");
                });

            modelBuilder.Entity("Manufactures.Domain.Rings.ReadModels.RingDocumentReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Identity");

                    b.ToTable("Weaving_RingDocuments");
                });

            modelBuilder.Entity("Manufactures.Domain.Suppliers.ReadModels.WeavingSupplierDocumentReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("CoreSupplierId");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Identity");

                    b.ToTable("Weaving_SupplierDocuments");
                });

            modelBuilder.Entity("Manufactures.Domain.Yarns.ReadModels.YarnDocumentReadModel", b =>
                {
                    b.Property<Guid>("Identity")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<string>("CoreCurrency")
                        .HasMaxLength(255);

                    b.Property<string>("CoreUom")
                        .HasMaxLength(255);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("DeletedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("DeletedDate");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("MaterialTypeDocument")
                        .HasMaxLength(255);

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(32);

                    b.Property<DateTimeOffset?>("ModifiedDate");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<double>("Price");

                    b.Property<string>("RingDocument")
                        .HasMaxLength(255);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("SupplierDocument")
                        .HasMaxLength(255);

                    b.Property<string>("Tags")
                        .HasMaxLength(255);

                    b.HasKey("Identity");

                    b.ToTable("Weaving_YarnDocuments");
                });

            modelBuilder.Entity("Manufactures.Domain.Construction.Entities.ConstructionDetail", b =>
                {
                    b.HasOne("Manufactures.Domain.Construction.ReadModels.ConstructionDocumentReadModel", "ConstructionDocument")
                        .WithMany("ConstructionDetails")
                        .HasForeignKey("ConstructionDocumentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
