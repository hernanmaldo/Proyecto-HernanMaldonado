namespace MaldoMotos
{
    partial class FormPartesDiarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            comboBoxTipo = new ComboBox();
            comboBoxCliente = new ComboBox();
            textBoxImporte = new TextBox();
            textBoxDescripcion = new TextBox();
            buttonGuardar = new Button();
            buttonLimiar = new Button();
            buttonAgregarRepuesto = new Button();
            textBoxMPoCodRe = new TextBox();
            labelMetodoPago = new Label();
            labelCodigoRepuesto = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            label6 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(992, 248);
            dataGridView1.TabIndex = 0;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Reparacion", "Pago" });
            comboBoxTipo.Location = new Point(27, 53);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(151, 28);
            comboBoxTipo.TabIndex = 1;
            comboBoxTipo.SelectedIndexChanged += comboBoxTipo_SelectedIndexChanged;
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(27, 126);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(151, 28);
            comboBoxCliente.TabIndex = 2;
            // 
            // textBoxImporte
            // 
            textBoxImporte.Location = new Point(27, 228);
            textBoxImporte.Name = "textBoxImporte";
            textBoxImporte.Size = new Size(151, 27);
            textBoxImporte.TabIndex = 3;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(227, 156);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(378, 129);
            textBoxDescripcion.TabIndex = 4;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(872, 167);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(147, 57);
            buttonGuardar.TabIndex = 5;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonLimiar
            // 
            buttonLimiar.Location = new Point(872, 230);
            buttonLimiar.Name = "buttonLimiar";
            buttonLimiar.Size = new Size(147, 55);
            buttonLimiar.TabIndex = 6;
            buttonLimiar.Text = "Limpiar";
            buttonLimiar.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarRepuesto
            // 
            buttonAgregarRepuesto.Location = new Point(437, 86);
            buttonAgregarRepuesto.Name = "buttonAgregarRepuesto";
            buttonAgregarRepuesto.Size = new Size(168, 29);
            buttonAgregarRepuesto.TabIndex = 7;
            buttonAgregarRepuesto.Text = "Agregar Repuesto";
            buttonAgregarRepuesto.UseVisualStyleBackColor = true;
            buttonAgregarRepuesto.Visible = false;
            // 
            // textBoxMPoCodRe
            // 
            textBoxMPoCodRe.Location = new Point(227, 53);
            textBoxMPoCodRe.Name = "textBoxMPoCodRe";
            textBoxMPoCodRe.Size = new Size(378, 27);
            textBoxMPoCodRe.TabIndex = 8;
            // 
            // labelMetodoPago
            // 
            labelMetodoPago.AutoSize = true;
            labelMetodoPago.Location = new Point(227, 30);
            labelMetodoPago.Name = "labelMetodoPago";
            labelMetodoPago.Size = new Size(120, 20);
            labelMetodoPago.TabIndex = 9;
            labelMetodoPago.Text = "Metodo de Pago";
            labelMetodoPago.Visible = false;
            // 
            // labelCodigoRepuesto
            // 
            labelCodigoRepuesto.AutoSize = true;
            labelCodigoRepuesto.Location = new Point(227, 30);
            labelCodigoRepuesto.Name = "labelCodigoRepuesto";
            labelCodigoRepuesto.Size = new Size(124, 20);
            labelCodigoRepuesto.TabIndex = 10;
            labelCodigoRepuesto.Text = "Codigo Repuesto";
            labelCodigoRepuesto.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 21);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 11;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 94);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 12;
            label4.Text = "Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 193);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 13;
            label5.Text = "Importe";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(642, 53);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(201, 232);
            dataGridView2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(227, 126);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 15;
            label6.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(642, 30);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 16;
            label1.Text = "Repuestos Seleccionados";
            label1.Visible = false;
            // 
            // FormPartesDiarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 600);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(dataGridView2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(labelCodigoRepuesto);
            Controls.Add(labelMetodoPago);
            Controls.Add(textBoxMPoCodRe);
            Controls.Add(buttonAgregarRepuesto);
            Controls.Add(buttonLimiar);
            Controls.Add(buttonGuardar);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxImporte);
            Controls.Add(comboBoxCliente);
            Controls.Add(comboBoxTipo);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPartesDiarios";
            Text = "FormPartesDiarios";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBoxTipo;
        private ComboBox comboBoxCliente;
        private TextBox textBoxImporte;
        private TextBox textBoxDescripcion;
        private Button buttonGuardar;
        private Button buttonLimiar;
        private Button buttonAgregarRepuesto;
        private TextBox textBoxMPoCodRe;
        private Label labelMetodoPago;
        private Label labelCodigoRepuesto;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView2;
        private Label label6;
        private Label label1;
    }
}