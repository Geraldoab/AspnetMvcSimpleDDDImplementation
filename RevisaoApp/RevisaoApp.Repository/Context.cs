using RevisaoApp.Domain.Entities;
using RevisaoApp.Repository.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoApp.Repository
{
    public class Context : DbContext
    {
        public Context() : base("Name=revisaoConnection")
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}