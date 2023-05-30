using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMaldoMotos.Entidades
{
    public class Cliente
    {
        public int ClienteID { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public int Saldo { get; set; }

        //navegacion
        public ICollection<Moto> Motos { get; set; }

        public ICollection<Evento> Eventos { get; set; }
        //



        /*
        public int getId() { return ClienteId; }
      
        public string getNombre(){return Nombre;}

        public string getApellido() { return Apellido; }

        public string getTelefono() { return Telefono; }

        public int getSaldo() { return Saldo; }

        public ICollection<Moto> getMotos() { return Motos; }  

        public void setNombre(string nombre ) { Nombre = nombre; }

        public void setApellido(string apellido) { Apellido = apellido; }

        public void setTelefono(string telefono) {Telefono = telefono; }

        public void setSaldo(int saldo) { Saldo += saldo;}

        public void AddMoto(Moto moto) {
        Motos.Add(moto);
        }

        */

    }
}
