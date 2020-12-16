using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CitraDataStore.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<EstacionesAsignadas> EstacionesAsignadas { get; set; }
        public virtual DbSet<Estacioneve> Estacioneve { get; set; }
        public virtual DbSet<Instrumento> Instrumento { get; set; }
        public virtual DbSet<LinkRolesMenus> LinkRolesMenus { get; set; }
        public virtual DbSet<Medicion> Medicion { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseMySql("Server=localhost;Database=wwbiov_citrads;User=wwbiov_admin;Password=c1tr4084!" + '"'+"#");
                optionsBuilder.UseMySql("Server=citrads.cmmqgr4kvqxz.us-east-2.rds.amazonaws.com;Database=citra;User=admin;Password=c1tr420cds");
                //optionsBuilder.UseMySql("Server=127.0.0.1;Database=citrads;User=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admins>(entity =>
            {
                entity.ToTable("admins");

                entity.HasIndex(e => e.RolesId)
                    .HasName("admins_ibfk_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasColumnType("varchar(255)");
               
                entity.Property(e => e.IdEstacionesAsignadas)
                    .HasColumnName("id_estaciones_asignadas")
                    .HasColumnType("varchar(999)");

                entity.Property(e => e.RolesId)
                    .HasColumnName("roles_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Dias_disponibles)
                    .HasColumnName("dias_disponibles")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.Admins)
                    .HasForeignKey(d => d.RolesId)
                    .HasConstraintName("admins_ibfk_1");
            });

            modelBuilder.Entity<EstacionesAsignadas>(entity =>
            {
                entity.ToTable("estaciones_asignadas");

                entity.HasIndex(e => e.Idestacion)
                    .HasName("idestacion");

                entity.HasIndex(e => e.Idusuario)
                    .HasName("idusuario");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(32)");

                entity.Property(e => e.Idestacion)
                    .HasColumnName("idestacion")
                    .HasColumnType("int(32)");

                entity.Property(e => e.Idusuario)
                    .HasColumnName("idusuario")
                    .HasColumnType("int(32)");

                entity.HasOne(d => d.IdestacionNavigation)
                    .WithMany(p => p.EstacionesAsignadas)
                    .HasForeignKey(d => d.Idestacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("estaciones_asignadas_ibfk_1");

                entity.HasOne(d => d.IdusuarioNavigation)
                    .WithMany(p => p.EstacionesAsignadas)
                    .HasForeignKey(d => d.Idusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("estaciones_asignadas_ibfk_2");
            });

            modelBuilder.Entity<Estacioneve>(entity =>
            {
                entity.ToTable("estacioneve");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdconId)
                    .HasColumnName("adcon_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Altura).HasColumnName("altura");

                entity.Property(e => e.Clonar)
                    .HasColumnName("clonar")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descargar)
                    .HasColumnName("descargar")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EstacionClonId)
                    .HasColumnName("estacion_clon_id")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("tinytext");

                entity.Property(e => e.FuenteDeDatosId)
                    .HasColumnName("fuente_de_datos_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IntentosDeDescarga)
                    .HasColumnName("intentos_de_descarga")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Rtu)
                    .HasColumnName("RTU")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Instrumento>(entity =>
            {
                entity.ToTable("instrumento");

                entity.HasIndex(e => e.EstacionId)
                    .HasName("fk_instrumento_estacion");

                entity.HasIndex(e => e.ResponsableId)
                    .HasName("fk_instrumento_responsable");

                entity.HasIndex(e => e.TipoInstrumentoId)
                    .HasName("fk_instrumento_tipo_instrumento");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdconId)
                    .HasColumnName("adcon_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EstacionId)
                    .HasColumnName("estacion_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FechaInstalacion)
                    .HasColumnName("fecha_instalacion")
                    .HasColumnType("date");

                entity.Property(e => e.Marca)
                    .HasColumnName("marca")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Modelo)
                    .HasColumnName("modelo")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Observacion)
                    .HasColumnName("observacion")
                    .HasColumnType("text");

                entity.Property(e => e.ResponsableId)
                    .HasColumnName("responsable_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RevisarDatos)
                    .HasColumnName("revisar_datos")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoInstrumentoId)
                    .HasColumnName("tipo_instrumento_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UbicacionNombre)
                    .HasColumnName("ubicacion_nombre")
                    .HasColumnType("text");

                entity.Property(e => e.Unidad)
                    .IsRequired()
                    .HasColumnName("unidad")
                    .HasColumnType("tinytext");
            });

            modelBuilder.Entity<LinkRolesMenus>(entity =>
            {
                entity.ToTable("link_roles_menus");

                entity.HasIndex(e => e.MenusId)
                    .HasName("menus_id");

                entity.HasIndex(e => e.RolesId)
                    .HasName("roles_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MenusId)
                    .HasColumnName("menus_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RolesId)
                    .HasColumnName("roles_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Menus)
                    .WithMany(p => p.LinkRolesMenus)
                    .HasForeignKey(d => d.MenusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("link_roles_menus_ibfk_1");

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.LinkRolesMenus)
                    .HasForeignKey(d => d.RolesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("link_roles_menus_ibfk_2");
            });

            modelBuilder.Entity<Medicion>(entity =>
            {
                entity.HasKey(e => new { e.Fecha, e.Hora, e.InstrumentoId })
                    .HasName("PRIMARY");

                entity.ToTable("medicion");

                entity.HasIndex(e => e.Fecha)
                    .HasName("fecha");

                entity.HasIndex(e => e.Hora)
                    .HasName("hora");

                entity.HasIndex(e => e.InstrumentoId)
                    .HasName("fk_medicion_instrumento");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Hora)
                    .HasColumnName("hora")
                    .HasColumnType("time");

                entity.Property(e => e.InstrumentoId)
                    .HasColumnName("instrumento_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Medicion1).HasColumnName("medicion");
            });

            modelBuilder.Entity<Menus>(entity =>
            {
                entity.ToTable("menus");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)");
            });
        }
    }
}
