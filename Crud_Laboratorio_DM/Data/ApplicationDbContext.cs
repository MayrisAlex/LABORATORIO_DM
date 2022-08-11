using Crud_Laboratorio_DM.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud_Laboratorio_DM.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Cliente> Cliente { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Cliente>(en => {
            en.HasKey(e => e.ID_CLIENTE);
        
            en.Property(e => e.CEDULA).IsUnicode(false);
            en.Property(e => e.NOMBRE).HasMaxLength(50).IsUnicode(false);
            en.Property(e => e.APELLIDO).HasMaxLength(50).IsUnicode(false);
            en.Property(e => e.EMAIL).HasMaxLength(30).IsUnicode(false);
            en.Property(e => e.TELEFONO).IsUnicode(false);
            en.Property(e => e.DIRECCION).HasMaxLength(20).IsUnicode(false);
            en.Property(e => e.USUARIO).HasMaxLength(15).IsUnicode(false);

            });
        }
    }
}
