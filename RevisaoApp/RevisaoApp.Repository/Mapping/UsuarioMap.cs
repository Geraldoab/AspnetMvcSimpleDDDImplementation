using RevisaoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoApp.Repository.Mapping
{
    public sealed class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap() {

            this.ToTable("Usuario");

            this.HasKey(t => t.Codigo);

            this.Property(t => t.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
