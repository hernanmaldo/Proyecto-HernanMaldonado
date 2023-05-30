using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMaldoMotos.Entidades
{
    public abstract class Evento
    {
        public int EventoId { get; set; }

        public string Tipo { get; set; } = null!; 
        public int Importe { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime Fecha { get; set; }

        public Reparacion Reparacion { get; set; }  

        public Pago Pago { get; set; }  
        public int ClienteId { get; set; }
        public Cliente cliente { get; set; } = null!;



        /*
        public  int getId() { return EventoId; }

        public int getImporte() { return Importe; } 

        public string getDescripcion() { return Descripcion; }
        
        public Cliente getCliente() { return cliente; }
        */

    }
}
