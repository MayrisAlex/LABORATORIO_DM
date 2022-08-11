using CRUD_LABORATORIO.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_LABORATORIO.Data
{
    public class ApplicationDbContext : IdentityDbContext
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

            en.Property(e => e.CEDULA).HasMaxLength(10).IsUnicode(false);
            en.Property(e => e.NOMBRE).HasMaxLength(100).IsUnicode(false); ;
            en.Property(e => e.APELLIDO).HasMaxLength(100).IsUnicode(false); ;
            en.Property(e => e.EMAIL).HasMaxLength(50).IsUnicode(false); ;
            en.Property(e => e.TELEFONO).HasMaxLength(15).IsUnicode(false); ;
            en.Property(e => e.DIRECCION).HasMaxLength(50).IsUnicode(false); ;
            en.Property(e => e.USUARIO).HasMaxLength(50).IsUnicode(false); ;


            } );
        }
    }
}
