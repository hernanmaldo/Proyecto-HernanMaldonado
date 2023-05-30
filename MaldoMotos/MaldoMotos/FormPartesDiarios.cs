using BibliotecaMaldoMotos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaldoMotos
{
    public partial class FormPartesDiarios : Form
    {

        private ApplicationDbContext? dbContext;
        public FormPartesDiarios()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new ApplicationDbContext();

            // Uncomment the line below to start fresh with a new database.
            //this.dbContext.Database.EnsureDeleted();

            this.dbContext.Database.EnsureCreated();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }




        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedIndex == 1)
            {
                labelCodigoRepuesto.Visible = false;
                buttonAgregarRepuesto.Visible = false;
                labelMetodoPago.Visible = true;
            }

            if (comboBoxTipo.SelectedIndex == 0)
            {
                labelMetodoPago.Visible = false;
                buttonAgregarRepuesto.Visible = true;
                labelCodigoRepuesto.Visible = true;
            }
        }
    }
}
