﻿// <auto-generated />
using CustomerDetailSystem.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerDetailSystem.Migrations
{
    [DbContext(typeof(CustomerDetailContext))]
    partial class CustomerDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerDetailSystem.Model.CustomerDetail", b =>
                {
                    b.Property<int>("CUST_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CUST_ADDRESS")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CUST_FIRST_NM")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CUST_LAST_NM")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CUST_MID_NM")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CUST_MOBILE_NO")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.HasKey("CUST_ID");

                    b.ToTable("CustomerDetails");
                });
#pragma warning restore 612, 618
        }
    }
}