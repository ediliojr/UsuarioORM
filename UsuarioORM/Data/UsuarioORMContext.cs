using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsuarioORM.Models;

namespace UsuarioORM.Data
{
    public class UsuarioORMContext : DbContext
    {
        public UsuarioORMContext (DbContextOptions<UsuarioORMContext> options)
            : base(options)
        {
        }

        public DbSet<UsuarioORM.Models.Usuario> Usuario { get; set; } = default!;
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new UsuarioMap());

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
