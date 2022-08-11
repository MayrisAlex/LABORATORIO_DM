using CRUD_LABORATORIO_DM1._0.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_LABORATORIO_DM1._0.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, UserRole,string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
   
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CLIENTE>(en =>
            {
                en.HasKey(e => e.ID_CLIENTE);

                en.Property(e => e.CEDULA).IsRequired().HasMaxLength(10).IsUnicode(false);
                en.Property(e => e.NOMBRE).IsRequired().HasMaxLength(100).IsUnicode(false); ;
                en.Property(e => e.APELLIDO).IsRequired().HasMaxLength(100).IsUnicode(false); ;
                en.Property(e => e.EMAIL).IsRequired().HasMaxLength(50).IsUnicode(false); ;
                en.Property(e => e.TELEFONO).IsRequired().HasMaxLength(15).IsUnicode(false); ;
                en.Property(e => e.DIRECCION).IsRequired().HasMaxLength(50).IsUnicode(false); ;
            en.Property(e => e.DESCRIPCION_SERVICIO).IsRequired().HasMaxLength(50).IsUnicode(false);
            en.Property(e => e.FECHA_RECEPCION).IsRequired().HasMaxLength(50).IsUnicode(false);

            en.Property(e => e.FECHA_ENTREGA).IsRequired().HasMaxLength(50).IsUnicode(false);

            en.Property(e => e.OBSERVACIONES).IsRequired().HasMaxLength(50).IsUnicode(false);
            en.Property(e => e.USUARIO).IsRequired().HasMaxLength(50).IsUnicode(false); 
  

            });
        }
    }
}
