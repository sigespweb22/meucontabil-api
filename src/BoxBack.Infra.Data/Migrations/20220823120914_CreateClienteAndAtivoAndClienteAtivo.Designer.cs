﻿// <auto-generated />
using System;
using BoxBack.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BoxBack.Infra.Data.Migrations
{
    [DbContext(typeof(BoxAppDbContext))]
    [Migration("20220823120914_CreateClienteAndAtivoAndClienteAtivo")]
    partial class CreateClienteAndAtivoAndClienteAtivo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<Guid>("TenantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValue(new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"));

                    b.Property<string>("UniqueKey")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("AspNetGroups", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822"),
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 8, 23, 9, 9, 13, 366, DateTimeKind.Unspecified).AddTicks(3448), new TimeSpan(0, -3, 0, 0, 0)),
                            CreatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            IsDeleted = false,
                            Name = "Master",
                            TenantId = new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"),
                            UniqueKey = "ors0eAr4DPkvrwhy5gVnQAqRDnJUO43j9HzbkPyZ/7Q=",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 8, 23, 9, 9, 13, 366, DateTimeKind.Unspecified).AddTicks(3470), new TimeSpan(0, -3, 0, 0, 0)),
                            UpdatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        });
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                            ConcurrencyStamp = "da8e4f70-8be9-4d8f-a684-5b97f19d252c",
                            Name = "Master",
                            NormalizedName = "MASTER"
                        });
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationRoleGroup", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uuid");

                    b.HasKey("RoleId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("AspNetRoleGroups", (string)null);

                    b.HasData(
                        new
                        {
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                            GroupId = new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822")
                        });
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("UserId");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Avatar")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<int>("Funcao")
                        .HasColumnType("integer");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<int>("Setor")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<Guid>("TenantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValue(new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"));

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("TenantId");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            Avatar = "",
                            ConcurrencyStamp = "ca431822-360a-4ee6-b978-66564d429fc7",
                            Email = "alan.rezende@boxtecnologia.com.br",
                            EmailConfirmed = true,
                            FullName = "ALAN LEITE DE REZENDE",
                            Funcao = 0,
                            LockoutEnabled = false,
                            NormalizedEmail = "ALAN.REZENDE@BOXTECNOLOGIA.COM.BR",
                            NormalizedUserName = "ALAN.REZENDE@BOXTECNOLOGIA.COM.BR",
                            PasswordHash = "AQAAAAEAACcQAAAAEFGbgHKOKiDDs5fvXN8kHviorntHToMKurnVJNmsFQNInxhQOyZTwJ2w0SpbyCdZbA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c9514850-61dd-4cc1-b909-88b79b035643",
                            Setor = 0,
                            Status = 0,
                            TenantId = new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"),
                            TwoFactorEnabled = false,
                            UserName = "alan.rezende@boxtecnologia.com.br"
                        });
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationUserGroup", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("AspNetUserGroups", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            GroupId = new Guid("23e63d9c-283b-496b-b7d8-7dac2ef7a822")
                        });
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210"
                        },
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "b3a5b61d-7ff4-43cb-bad4-a945b150fc72"
                        });
                });

            modelBuilder.Entity("BoxBack.Domain.Models.Ativo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("Caracteristica")
                        .HasMaxLength(1500)
                        .HasColumnType("character varying(1500)");

                    b.Property<int>("ClienteAtivoTipoServicoTipo")
                        .HasColumnType("integer");

                    b.Property<string>("CodigoUnico")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Observacao")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Referencia")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<Guid>("TenantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValue(new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"));

                    b.Property<int>("Tipo")
                        .HasColumnType("integer");

                    b.Property<int>("UnidadeMedida")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.Property<decimal>("ValorCusto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(7,3)")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("ValorVenda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(7,3)")
                        .HasDefaultValue(0m);

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Ativos", (string)null);
                });

            modelBuilder.Entity("BoxBack.Domain.Models.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Cep")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("20");

                    b.Property<string>("Cidade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("255");

                    b.Property<int?>("CodigoMunicipio")
                        .HasColumnType("integer");

                    b.Property<string>("Complemento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("50");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("DataFundacao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EmailPrincipal")
                        .HasColumnType("text");

                    b.Property<string>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("4");

                    b.Property<string>("InscricaoEstadual")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Numero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("5");

                    b.Property<string>("Observacao")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Rua")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("text")
                        .HasDefaultValue("500");

                    b.Property<string>("TelefonePrincipal")
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)");

                    b.Property<Guid>("TenantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasDefaultValue(new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"));

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("TenantId");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ClienteAtivo", b =>
                {
                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("AtivoId")
                        .HasColumnType("uuid");

                    b.HasKey("ClienteId", "AtivoId");

                    b.HasIndex("AtivoId");

                    b.ToTable("ClientesAtivos", (string)null);
                });

            modelBuilder.Entity("BoxBack.Domain.Models.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ApiKey")
                        .HasColumnType("uuid");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("EmailPrincipal")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("NomeExibicao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("text");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.Property<string>("WhatsAppPrincipal")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ApiKey")
                        .IsUnique();

                    b.HasIndex("Cnpj")
                        .IsUnique();

                    b.ToTable("Tenants", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d8fe3845-3f2e-4b4e-aeb6-53222d60ff45"),
                            ApiKey = new Guid("57d390e7-2b87-47fe-9bc8-0bae3a388499"),
                            Cnpj = "12.368.943/0001-50",
                            CreatedAt = new DateTimeOffset(new DateTime(2022, 8, 23, 9, 9, 13, 364, DateTimeKind.Unspecified).AddTicks(5364), new TimeSpan(0, -3, 0, 0, 0)),
                            CreatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            EmailPrincipal = "rafale@boxtecnologia.com.br",
                            IsDeleted = false,
                            Nome = "Box Tecnologia Ltda",
                            NomeExibicao = "Box Tecnologia",
                            UpdatedAt = new DateTimeOffset(new DateTime(2022, 8, 23, 9, 9, 13, 364, DateTimeKind.Unspecified).AddTicks(5394), new TimeSpan(0, -3, 0, 0, 0)),
                            UpdatedBy = "8e445865-a24d-4543-a6c6-9443d048cdb9"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationGroup", b =>
                {
                    b.HasOne("BoxBack.Domain.Models.Tenant", "Tenant")
                        .WithMany("ApplicationGroups")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationRoleGroup", b =>
                {
                    b.HasOne("BoxBack.Domain.Models.ApplicationGroup", "ApplicationGroup")
                        .WithMany("ApplicationRoleGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BoxBack.Domain.Models.ApplicationRole", "ApplicationRole")
                        .WithMany("ApplicationRoleGroups")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ApplicationGroup");

                    b.Navigation("ApplicationRole");
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationUser", b =>
                {
                    b.HasOne("BoxBack.Domain.Models.Tenant", "Tenant")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationUserClaim", b =>
                {
                    b.HasOne("BoxBack.Domain.Models.ApplicationUser", null)
                        .WithMany("ApplicationUserClaims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationUserGroup", b =>
                {
                    b.HasOne("BoxBack.Domain.Models.ApplicationGroup", "ApplicationGroup")
                        .WithMany("ApplicationUserGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BoxBack.Domain.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("ApplicationUserGroups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ApplicationGroup");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationUserRole", b =>
                {
                    b.HasOne("BoxBack.Domain.Models.ApplicationRole", "ApplicationRole")
                        .WithMany("ApplicationUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoxBack.Domain.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("ApplicationUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ApplicationRole");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("BoxBack.Domain.Models.Ativo", b =>
                {
                    b.HasOne("BoxBack.Domain.Models.Tenant", "Tenant")
                        .WithMany("Ativos")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("BoxBack.Domain.Models.Cliente", b =>
                {
                    b.HasOne("BoxBack.Domain.Models.Tenant", "Tenant")
                        .WithMany("Clientes")
                        .HasForeignKey("TenantId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ClienteAtivo", b =>
                {
                    b.HasOne("BoxBack.Domain.Models.Ativo", "Ativo")
                        .WithMany("Clientes")
                        .HasForeignKey("AtivoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("BoxBack.Domain.Models.Cliente", "Cliente")
                        .WithMany("Ativos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Ativo");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("BoxBack.Domain.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BoxBack.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BoxBack.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationGroup", b =>
                {
                    b.Navigation("ApplicationRoleGroups");

                    b.Navigation("ApplicationUserGroups");
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationRole", b =>
                {
                    b.Navigation("ApplicationRoleGroups");

                    b.Navigation("ApplicationUserRoles");
                });

            modelBuilder.Entity("BoxBack.Domain.Models.ApplicationUser", b =>
                {
                    b.Navigation("ApplicationUserClaims");

                    b.Navigation("ApplicationUserGroups");

                    b.Navigation("ApplicationUserRoles");
                });

            modelBuilder.Entity("BoxBack.Domain.Models.Ativo", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("BoxBack.Domain.Models.Cliente", b =>
                {
                    b.Navigation("Ativos");
                });

            modelBuilder.Entity("BoxBack.Domain.Models.Tenant", b =>
                {
                    b.Navigation("ApplicationGroups");

                    b.Navigation("ApplicationUsers");

                    b.Navigation("Ativos");

                    b.Navigation("Clientes");
                });
#pragma warning restore 612, 618
        }
    }
}
