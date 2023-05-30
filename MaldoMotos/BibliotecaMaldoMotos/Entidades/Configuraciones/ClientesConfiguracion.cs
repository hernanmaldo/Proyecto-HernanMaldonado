using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMaldoMotos.Entidades.Configuraciones
{
    public class ClientesConfiguracion: IEntityTypeConfiguration<Cliente>
    { 
        
            public void Configure(EntityTypeBuilder<Cliente> builder)
            {
               


            }
        }
}
