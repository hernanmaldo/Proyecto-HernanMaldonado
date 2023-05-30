using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMaldoMotos.Entidades
{
    public class Repuesto
    {
        public int RepuestoId { get; set; }

        public int RepuestoCod { get; set; }    

        public double Precio { get; set; }

        public string Marca { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string Descripcion { get; set; } = null!;

        public int Stock { get; set; }

        public ICollection<ReparacionRepuesto> ReparacionRepuestos { get; set; }



    }
}
