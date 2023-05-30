namespace MaldoMotos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form formhijo = Formhijo as Form;
            formhijo.TopLevel = false;
            formhijo.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(formhijo);
            this.panelContenedor.Tag = formhijo;
            formhijo.Show();
        }
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void buttonPartesDiarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormPartesDiarios());
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormClientes());
        }

        private void buttonRepuestos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRepuestos());
        }
    }
}