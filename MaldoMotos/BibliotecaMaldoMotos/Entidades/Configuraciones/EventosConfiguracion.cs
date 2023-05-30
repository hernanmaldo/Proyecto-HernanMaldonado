using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMaldoMotos.Entidades.Configuraciones
{
    public class EventosConfiguracion : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.HasOne(e => e.Reparacion).WithOne().HasForeignKey<Reparacion>(r => r.EventoId);

            builder.HasOne(e => e.Pago).WithOne().HasForeignKey<Pago>(p => p.EventoId);

        }
    }
}
