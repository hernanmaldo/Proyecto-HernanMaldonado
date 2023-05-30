using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMaldoMotos.Entidades
{
    public class Moto
    {
        public int MotoId { get; set; }

        public string Modelo { get; set;  } = null!;

        public string Marca { get; set; } = null!;

        public DateTime Anio { get; set;}

        //navegacion
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;

        /*
        public int getId() { return MotoId; }   

        public string getModelo() { return Modelo; }
       
        public string getMarca() { return Marca; }

        public DateTime getAnio() { return Anio; }

       // public Cliente getCliente() { return Cliente; } 
      */
    }
}
