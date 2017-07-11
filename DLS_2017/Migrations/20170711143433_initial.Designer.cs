using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DLS_2017.Models;

namespace DLS_2017.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20170711143433_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DLS_2017.Models.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("AlreadyWinner");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("DLS_2017.Models.Speaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("FaceBook");

                    b.Property<string>("GPlus");

                    b.Property<bool>("IsSelected");

                    b.Property<string>("Linkedin");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Photo");

                    b.Property<string>("PresetationDetails")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("PresetationSubject")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("SpeakerDetails")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Twitter");

                    b.HasKey("Id");

                    b.ToTable("Speakers");
                });
        }
    }
}
