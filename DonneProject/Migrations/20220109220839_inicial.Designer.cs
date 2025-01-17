﻿// <auto-generated />
using DonneProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DonneProject.Migrations
{
    [DbContext(typeof(DonneDbContext))]
<<<<<<< HEAD:DonneProject/Migrations/20220109234218_Inicial.Designer.cs
    [Migration("20220109234218_Inicial")]
    partial class Inicial
=======
    [Migration("20220109220839_inicial")]
    partial class inicial
>>>>>>> ccc31e23ab241812e89e1edbf6a519fbe92e5ba8:DonneProject/Migrations/20220109220839_inicial.Designer.cs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DonneProject.Models.Atuacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Atuacao");
                });

            modelBuilder.Entity("DonneProject.Models.CadastroParceiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NomeAreaId")
                        .HasColumnType("int");

                    b.Property<string>("RZsocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NomeAreaId");

                    b.ToTable("Parceiro");
                });

            modelBuilder.Entity("DonneProject.Models.CadastroSobrev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NomeFuncaoId")
                        .HasColumnType("int");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NomeFuncaoId");

                    b.ToTable("Sobrevivente");
                });

            modelBuilder.Entity("DonneProject.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contato");
                });

            modelBuilder.Entity("DonneProject.Models.Funcao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeFuncao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funcao");
                });

            modelBuilder.Entity("DonneProject.Models.CadastroParceiro", b =>
                {
                    b.HasOne("DonneProject.Models.Atuacao", "NomeArea")
                        .WithMany()
                        .HasForeignKey("NomeAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NomeArea");
                });

            modelBuilder.Entity("DonneProject.Models.CadastroSobrev", b =>
                {
                    b.HasOne("DonneProject.Models.Funcao", "NomeFuncao")
                        .WithMany()
                        .HasForeignKey("NomeFuncaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NomeFuncao");
                });
#pragma warning restore 612, 618
        }
    }
}
