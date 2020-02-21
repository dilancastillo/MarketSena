﻿// <auto-generated />
using System;
using MarketSENA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MarketSENA.Migrations
{
    [DbContext(typeof(MarketSENAContext))]
    [Migration("20200220191429_m8")]
    partial class m8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MarketSENA.Models.CiiuClase", b =>
                {
                    b.Property<int>("CiiuClaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CiiuGrupoID")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CiiuClaseID");

                    b.HasIndex("CiiuGrupoID");

                    b.ToTable("CiiuClase");
                });

            modelBuilder.Entity("MarketSENA.Models.CiiuDivision", b =>
                {
                    b.Property<int>("CiiuDivisionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CiiuSeccionID")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CiiuDivisionID");

                    b.HasIndex("CiiuSeccionID");

                    b.ToTable("CiiuDivision");
                });

            modelBuilder.Entity("MarketSENA.Models.CiiuGrupo", b =>
                {
                    b.Property<int>("CiiuGrupoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CiiuDivisionID")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CiiuGrupoID");

                    b.HasIndex("CiiuDivisionID");

                    b.ToTable("CiiuGrupo");
                });

            modelBuilder.Entity("MarketSENA.Models.CiiuSeccion", b =>
                {
                    b.Property<int>("CiiuSeccionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("CiiuSeccionID");

                    b.ToTable("CiiuSeccion");
                });

            modelBuilder.Entity("MarketSENA.Models.Componente", b =>
                {
                    b.Property<int>("ComponenteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SeccionID")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Visible")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ComponenteID");

                    b.HasIndex("SeccionID");

                    b.ToTable("Componente");
                });

            modelBuilder.Entity("MarketSENA.Models.Empresa", b =>
                {
                    b.Property<int>("EmpresaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GaleriaID")
                        .HasColumnType("int");

                    b.Property<int>("ModeloNegocioID")
                        .HasColumnType("int");

                    b.Property<string>("Nit")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RazonSocial")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SectorEconomicoID")
                        .HasColumnType("int");

                    b.HasKey("EmpresaID");

                    b.HasIndex("ModeloNegocioID");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("MarketSENA.Models.Galeria", b =>
                {
                    b.Property<int>("GaleriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UrlImg")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("GaleriaID");

                    b.ToTable("Galeria");
                });

            modelBuilder.Entity("MarketSENA.Models.ModeloNegocio", b =>
                {
                    b.Property<int>("ModeloNegocioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ModeloNegocioID");

                    b.ToTable("ModeloNegocio");
                });

            modelBuilder.Entity("MarketSENA.Models.Plantilla", b =>
                {
                    b.Property<int>("PlantillaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ModeloNegocioID")
                        .HasColumnType("int");

                    b.Property<bool>("Visible")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("PlantillaID");

                    b.HasIndex("ModeloNegocioID");

                    b.ToTable("Plantilla");
                });

            modelBuilder.Entity("MarketSENA.Models.Producto", b =>
                {
                    b.Property<int>("ProductoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Descuento")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("EmpresaID")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Promocion")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Unidad")
                        .HasColumnType("int");

                    b.Property<string>("UrlImg")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ProductoID");

                    b.HasIndex("EmpresaID");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("MarketSENA.Models.Rol", b =>
                {
                    b.Property<int>("RolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("RolID");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("MarketSENA.Models.Seccion", b =>
                {
                    b.Property<int>("SeccionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PlantillaID")
                        .HasColumnType("int");

                    b.Property<bool>("Visible")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("SeccionID");

                    b.HasIndex("PlantillaID");

                    b.ToTable("Seccion");
                });

            modelBuilder.Entity("MarketSENA.Models.SectorEconomico", b =>
                {
                    b.Property<int>("SectorEconomicoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CiiuClaseID")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Tipo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SectorEconomicoID");

                    b.HasIndex("CiiuClaseID");

                    b.ToTable("SectorEconomico");
                });

            modelBuilder.Entity("MarketSENA.Models.TipoRol", b =>
                {
                    b.Property<int>("TipoRolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("RolID")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("TipoRolID");

                    b.HasIndex("RolID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("TipoRol");
                });

            modelBuilder.Entity("MarketSENA.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Contrasenia")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("VerificacionEmail")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("MarketSENA.Models.UsuarioEmpresa", b =>
                {
                    b.Property<int>("UsuarioEmpresaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EmpresaID")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("UsuarioEmpresaID");

                    b.HasIndex("EmpresaID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("UsuarioEmpresa");
                });

            modelBuilder.Entity("MarketSENA.Models.CiiuClase", b =>
                {
                    b.HasOne("MarketSENA.Models.CiiuGrupo", "CiiuGrupo")
                        .WithMany()
                        .HasForeignKey("CiiuGrupoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarketSENA.Models.CiiuDivision", b =>
                {
                    b.HasOne("MarketSENA.Models.CiiuSeccion", "CiiuSeccion")
                        .WithMany()
                        .HasForeignKey("CiiuSeccionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarketSENA.Models.CiiuGrupo", b =>
                {
                    b.HasOne("MarketSENA.Models.CiiuDivision", "CiiuDivision")
                        .WithMany()
                        .HasForeignKey("CiiuDivisionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarketSENA.Models.Componente", b =>
                {
                    b.HasOne("MarketSENA.Models.Seccion", "Seccion")
                        .WithMany()
                        .HasForeignKey("SeccionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarketSENA.Models.Empresa", b =>
                {
                    b.HasOne("MarketSENA.Models.ModeloNegocio", "ModeloNegocio")
                        .WithMany()
                        .HasForeignKey("ModeloNegocioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarketSENA.Models.Plantilla", b =>
                {
                    b.HasOne("MarketSENA.Models.ModeloNegocio", "ModeloNegocio")
                        .WithMany()
                        .HasForeignKey("ModeloNegocioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarketSENA.Models.Producto", b =>
                {
                    b.HasOne("MarketSENA.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarketSENA.Models.Seccion", b =>
                {
                    b.HasOne("MarketSENA.Models.Plantilla", "Plantilla")
                        .WithMany()
                        .HasForeignKey("PlantillaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarketSENA.Models.SectorEconomico", b =>
                {
                    b.HasOne("MarketSENA.Models.CiiuClase", "CiiuClase")
                        .WithMany()
                        .HasForeignKey("CiiuClaseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarketSENA.Models.TipoRol", b =>
                {
                    b.HasOne("MarketSENA.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketSENA.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MarketSENA.Models.UsuarioEmpresa", b =>
                {
                    b.HasOne("MarketSENA.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketSENA.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
