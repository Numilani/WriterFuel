﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WriterFuel.Data;

#nullable disable

namespace WriterFuel.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WriterFuel.Data.CardComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CardText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CardType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ParentPack")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasDiscriminator<string>("CardType").HasValue("CardComponent");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("WriterFuel.Data.WritingPrompt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Pattern")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Prompts");
                });

            modelBuilder.Entity("WriterFuel.Data.AgentCard", b =>
                {
                    b.HasBaseType("WriterFuel.Data.CardComponent");

                    b.ToTable("Cards");

                    b.HasDiscriminator().HasValue("Agent");
                });

            modelBuilder.Entity("WriterFuel.Data.AnchorCard", b =>
                {
                    b.HasBaseType("WriterFuel.Data.CardComponent");

                    b.ToTable("Cards");

                    b.HasDiscriminator().HasValue("Anchor");
                });

            modelBuilder.Entity("WriterFuel.Data.AspectCard", b =>
                {
                    b.HasBaseType("WriterFuel.Data.CardComponent");

                    b.Property<int?>("AgentCardId")
                        .HasColumnType("integer");

                    b.Property<int?>("AnchorCardId")
                        .HasColumnType("integer");

                    b.Property<int?>("EngineCardId")
                        .HasColumnType("integer");

                    b.HasIndex("AgentCardId");

                    b.HasIndex("AnchorCardId");

                    b.HasIndex("EngineCardId");

                    b.ToTable("Cards");

                    b.HasDiscriminator().HasValue("Aspect");
                });

            modelBuilder.Entity("WriterFuel.Data.ConflictCard", b =>
                {
                    b.HasBaseType("WriterFuel.Data.CardComponent");

                    b.ToTable("Cards");

                    b.HasDiscriminator().HasValue("Conflict");
                });

            modelBuilder.Entity("WriterFuel.Data.EngineCard", b =>
                {
                    b.HasBaseType("WriterFuel.Data.CardComponent");

                    b.ToTable("Cards");

                    b.HasDiscriminator().HasValue("Engine");
                });

            modelBuilder.Entity("WriterFuel.Data.AspectCard", b =>
                {
                    b.HasOne("WriterFuel.Data.AgentCard", null)
                        .WithMany("Aspects")
                        .HasForeignKey("AgentCardId");

                    b.HasOne("WriterFuel.Data.AnchorCard", null)
                        .WithMany("Aspects")
                        .HasForeignKey("AnchorCardId");

                    b.HasOne("WriterFuel.Data.EngineCard", null)
                        .WithMany("Aspects")
                        .HasForeignKey("EngineCardId");
                });

            modelBuilder.Entity("WriterFuel.Data.AgentCard", b =>
                {
                    b.Navigation("Aspects");
                });

            modelBuilder.Entity("WriterFuel.Data.AnchorCard", b =>
                {
                    b.Navigation("Aspects");
                });

            modelBuilder.Entity("WriterFuel.Data.EngineCard", b =>
                {
                    b.Navigation("Aspects");
                });
#pragma warning restore 612, 618
        }
    }
}
