using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace BibliotecaMaldoMotos.Entidades.Configuraciones
{
  
  

        public class PeliculaActorConfig : IEntityTypeConfiguration<ReparacionRepuesto>
        {
            public void Configure(EntityTypeBuilder<ReparacionRepuesto> builder)
        {

            builder.HasKey(rr => new { rr.RepuestoId, rr.ReparacionId });

            builder
                .HasOne(rr => rr.Reparacion)
                .WithMany(r => r.ReparacionRepuestos)
                .HasForeignKey(r => r.ReparacionId);

           builder
                .HasOne(rr => rr.Repuesto)
                .WithMany(r => r.ReparacionRepuestos)
                .HasForeignKey(rr => rr.RepuestoId);
        }

        }
    
}
