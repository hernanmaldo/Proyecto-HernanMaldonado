using BibliotecaMaldoMotos.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMaldoMotos
{
    
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Moto> Motos { get; set; }        
        public DbSet<Reparacion> Reparaciones { get; set; }         
        public DbSet<Pago> Pagos { get; set; }  
        public DbSet<Repuesto> Repuestos { get; set; }  
        public DbSet<ReparacionRepuesto> ReparacionRepuestos { get; set; }        

      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MaldoMotos.db");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);

        }
    }
}
