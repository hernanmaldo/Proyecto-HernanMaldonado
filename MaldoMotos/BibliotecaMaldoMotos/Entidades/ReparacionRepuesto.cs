using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMaldoMotos.Entidades
{
    public class ReparacionRepuesto
    {
        public int ReparacionId { get; set; }

        public Reparacion Reparacion { get; set; }

        public int RepuestoId { get; set; }

        public Repuesto Repuesto { get; set; }

        public int CantidadUtilizada { get; set; }

    }
}
