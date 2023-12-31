﻿// <auto-generated />
using ApiAula.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiAula.Migrations
{
    [DbContext(typeof(ContextDB))]
    [Migration("20230704050811_initialmigration")]
    partial class initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiAula.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descricao");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real")
                        .HasColumnName("Valor");

                    b.HasKey("Id");

                    b.HasIndex("DisciplinaId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("ApiAula.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Duracao")
                        .HasColumnType("int")
                        .HasColumnName("Duracao");

                    b.Property<string>("Ementa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Ementa");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Disciplica");
                });

            modelBuilder.Entity("ApiAula.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Cpf");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nome");

                    b.Property<string>("Titulacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Titulacao");

                    b.HasKey("Id");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("ApiAula.Models.Curso", b =>
                {
                    b.HasOne("ApiAula.Models.Disciplina", "Disciplina")
                        .WithMany()
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiAula.Models.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disciplina");

                    b.Navigation("Professor");
                });
#pragma warning restore 612, 618
        }
    }
}
