﻿// <auto-generated />
using System;
using ControleDeGastos.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleDeGastos.Repository.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleDeGastos.Domain.Cartao", b =>
                {
                    b.Property<int>("IdCartao")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Agencia")
                        .IsRequired();

                    b.Property<string>("Banco")
                        .IsRequired();

                    b.Property<string>("Conta")
                        .IsRequired();

                    b.Property<string>("Cvv")
                        .IsRequired();

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataValidade");

                    b.Property<int>("DiaVencimento");

                    b.Property<string>("NomeSobrenome")
                        .IsRequired();

                    b.Property<string>("Numero")
                        .IsRequired();

                    b.Property<string>("Tipo")
                        .IsRequired();

                    b.Property<int?>("UsuarioIdUsuario");

                    b.HasKey("IdCartao");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Cartao");
                });

            modelBuilder.Entity("ControleDeGastos.Domain.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Titulo")
                        .IsRequired();

                    b.Property<int?>("UsuarioIdUsuario");

                    b.HasKey("IdCategoria");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("ControleDeGastos.Domain.Lancamento", b =>
                {
                    b.Property<int>("IdLancamento")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CartaoIdCartao");

                    b.Property<int?>("CategoriaIdCategoria");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataLancamento");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<int>("Parcelas");

                    b.Property<int?>("UsuarioIdUsuario");

                    b.Property<double>("Valor");

                    b.HasKey("IdLancamento");

                    b.HasIndex("CartaoIdCartao");

                    b.HasIndex("CategoriaIdCategoria");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Lancamento");
                });

            modelBuilder.Entity("ControleDeGastos.Domain.Meta", b =>
                {
                    b.Property<int>("IdMeta")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Conquistada");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataFinal");

                    b.Property<string>("Texto")
                        .IsRequired();

                    b.Property<int?>("UsuarioIdUsuario");

                    b.HasKey("IdMeta");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Meta");
                });

            modelBuilder.Entity("ControleDeGastos.Domain.Poupanca", b =>
                {
                    b.Property<int>("IdPoupanca")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CartaoIdCartao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataDeposito");

                    b.Property<int?>("UsuarioIdUsuario");

                    b.Property<double>("Valor");

                    b.HasKey("IdPoupanca");

                    b.HasIndex("CartaoIdCartao");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Poupanca");
                });

            modelBuilder.Entity("ControleDeGastos.Domain.Recebimento", b =>
                {
                    b.Property<int>("IdRecebimento")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataRecebimento");

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("Fornecedor")
                        .IsRequired();

                    b.Property<int?>("UsuarioIdUsuario");

                    b.Property<double>("Valor");

                    b.HasKey("IdRecebimento");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Recebimento");
                });

            modelBuilder.Entity("ControleDeGastos.Domain.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Login")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<double>("Salario");

                    b.Property<string>("Senha")
                        .IsRequired();

                    b.Property<string>("Sobrenome")
                        .IsRequired();

                    b.Property<Guid>("Token");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ControleDeGastos.Domain.UsuarioLogado", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ControleDeGastos.Domain.Cartao", b =>
                {
                    b.HasOne("ControleDeGastos.Domain.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario");
                });

            modelBuilder.Entity("ControleDeGastos.Domain.Categoria", b =>
                {
                    b.HasOne("ControleDeGastos.Domain.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario");
                });

            modelBuilder.Entity("ControleDeGastos.Domain.Lancamento", b =>
                {
                    b.HasOne("ControleDeGastos.Domain.Cartao", "Cartao")
                        .WithMany()
                        .HasForeignKey("CartaoIdCartao");

                    b.HasOne("ControleDeGastos.Domain.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaIdCategoria");

                    b.HasOne("ControleDeGastos.Domain.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario");
                });

            modelBuilder.Entity("ControleDeGastos.Domain.Meta", b =>
                {
                    b.HasOne("ControleDeGastos.Domain.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario");
                });

            modelBuilder.Entity("ControleDeGastos.Domain.Poupanca", b =>
                {
                    b.HasOne("ControleDeGastos.Domain.Cartao", "Cartao")
                        .WithMany()
                        .HasForeignKey("CartaoIdCartao");

                    b.HasOne("ControleDeGastos.Domain.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario");
                });

            modelBuilder.Entity("ControleDeGastos.Domain.Recebimento", b =>
                {
                    b.HasOne("ControleDeGastos.Domain.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ControleDeGastos.Domain.UsuarioLogado")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ControleDeGastos.Domain.UsuarioLogado")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ControleDeGastos.Domain.UsuarioLogado")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ControleDeGastos.Domain.UsuarioLogado")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
