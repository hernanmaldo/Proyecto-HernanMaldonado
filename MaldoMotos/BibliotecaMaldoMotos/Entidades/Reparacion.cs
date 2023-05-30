using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMaldoMotos.Entidades
{
    public class Reparacion : Evento
    {
        public int EventoId { get; set; }   
        public int ReparacionId { get; set; }   
        public ICollection<ReparacionRepuesto> ReparacionRepuestos { get; set; }

        public void UtilizarRepuesto(Repuesto repuesto, int cantidad)
        {
            if (repuesto.Stock >= cantidad)
            {
                repuesto.Stock -= cantidad;

            }

        }
    }
}
