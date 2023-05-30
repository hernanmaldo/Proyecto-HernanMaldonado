namespace MaldoMotos
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            panelMenu = new Panel();
            buttonClientes = new Button();
            buttonRepuestos = new Button();
            buttonPartesDiarios = new Button();
            panelTitulo = new Panel();
            iconrestaurar = new PictureBox();
            iconminimizar = new PictureBox();
            iconmaximizar = new PictureBox();
            iconcerrar = new PictureBox();
            panelContenedor = new Panel();
            panelMenu.SuspendLayout();
            panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 122, 204);
            panelMenu.Controls.Add(buttonClientes);
            panelMenu.Controls.Add(buttonRepuestos);
            panelMenu.Controls.Add(buttonPartesDiarios);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 650);
            panelMenu.TabIndex = 0;
            // 
            // buttonClientes
            // 
            buttonClientes.FlatAppearance.BorderSize = 0;
            buttonClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonClientes.FlatStyle = FlatStyle.Flat;
            buttonClientes.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClientes.ForeColor = SystemColors.MenuBar;
            buttonClientes.Image = (Image)resources.GetObject("buttonClientes.Image");
            buttonClientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonClientes.Location = new Point(0, 160);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(250, 75);
            buttonClientes.TabIndex = 2;
            buttonClientes.Text = "Clientes";
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // buttonRepuestos
            // 
            buttonRepuestos.FlatAppearance.BorderSize = 0;
            buttonRepuestos.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonRepuestos.FlatStyle = FlatStyle.Flat;
            buttonRepuestos.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRepuestos.ForeColor = SystemColors.MenuBar;
            buttonRepuestos.Image = (Image)resources.GetObject("buttonRepuestos.Image");
            buttonRepuestos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRepuestos.Location = new Point(0, 240);
            buttonRepuestos.Name = "buttonRepuestos";
            buttonRepuestos.Size = new Size(250, 75);
            buttonRepuestos.TabIndex = 1;
            buttonRepuestos.Text = "Repuestos";
            buttonRepuestos.UseVisualStyleBackColor = true;
            buttonRepuestos.Click += buttonRepuestos_Click;
            // 
            // buttonPartesDiarios
            // 
            buttonPartesDiarios.FlatAppearance.BorderSize = 0;
            buttonPartesDiarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            buttonPartesDiarios.FlatStyle = FlatStyle.Flat;
            buttonPartesDiarios.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPartesDiarios.ForeColor = SystemColors.MenuBar;
            buttonPartesDiarios.Image = (Image)resources.GetObject("buttonPartesDiarios.Image");
            buttonPartesDiarios.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPartesDiarios.Location = new Point(0, 80);
            buttonPartesDiarios.Name = "buttonPartesDiarios";
            buttonPartesDiarios.Size = new Size(250, 75);
            buttonPartesDiarios.TabIndex = 0;
            buttonPartesDiarios.Text = "Partes Diarios";
            buttonPartesDiarios.UseVisualStyleBackColor = true;
            buttonPartesDiarios.Click += buttonPartesDiarios_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(iconrestaurar);
            panelTitulo.Controls.Add(iconminimizar);
            panelTitulo.Controls.Add(iconmaximizar);
            panelTitulo.Controls.Add(iconcerrar);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(250, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1050, 50);
            panelTitulo.TabIndex = 1;
            // 
            // iconrestaurar
            // 
            iconrestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconrestaurar.Cursor = Cursors.Hand;
            iconrestaurar.Image = (Image)resources.GetObject("iconrestaurar.Image");
            iconrestaurar.Location = new Point(982, 12);
            iconrestaurar.Name = "iconrestaurar";
            iconrestaurar.Size = new Size(25, 25);
            iconrestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            iconrestaurar.TabIndex = 3;
            iconrestaurar.TabStop = false;
            iconrestaurar.Visible = false;
            iconrestaurar.Click += iconrestaurar_Click;
            // 
            // iconminimizar
            // 
            iconminimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconminimizar.Cursor = Cursors.Hand;
            iconminimizar.Image = (Image)resources.GetObject("iconminimizar.Image");
            iconminimizar.Location = new Point(951, 12);
            iconminimizar.Name = "iconminimizar";
            iconminimizar.Size = new Size(25, 25);
            iconminimizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconminimizar.TabIndex = 1;
            iconminimizar.TabStop = false;
            iconminimizar.Click += iconminimizar_Click;
            // 
            // iconmaximizar
            // 
            iconmaximizar.Cursor = Cursors.Hand;
            iconmaximizar.Image = (Image)resources.GetObject("iconmaximizar.Image");
            iconmaximizar.Location = new Point(982, 12);
            iconmaximizar.Name = "iconmaximizar";
            iconmaximizar.Size = new Size(25, 25);
            iconmaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            iconmaximizar.TabIndex = 2;
            iconmaximizar.TabStop = false;
            iconmaximizar.Click += iconmaximizar_Click;
            // 
            // iconcerrar
            // 
            iconcerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconcerrar.Cursor = Cursors.Hand;
            iconcerrar.Image = (Image)resources.GetObject("iconcerrar.Image");
            iconcerrar.Location = new Point(1013, 12);
            iconcerrar.Name = "iconcerrar";
            iconcerrar.Size = new Size(25, 25);
            iconcerrar.SizeMode = PictureBoxSizeMode.Zoom;
            iconcerrar.TabIndex = 0;
            iconcerrar.TabStop = false;
            iconcerrar.Click += iconcerrar_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelContenedor.Location = new Point(250, 50);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1050, 600);
            panelContenedor.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(panelContenedor);
            Controls.Add(panelTitulo);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuPrincipal";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconrestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconminimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconmaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconcerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitulo;
        private PictureBox iconminimizar;
        private PictureBox iconmaximizar;
        private PictureBox iconcerrar;
        private Panel panelContenedor;
        private PictureBox iconrestaurar;
        private Button buttonPartesDiarios;
        private Button buttonClientes;
        private Button buttonRepuestos;
    }
}