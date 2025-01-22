namespace AdoNetCorePractica
{
    partial class PracticaEmpleadosDepartamento
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
            label1 = new Label();
            cmbDepartamentos = new ComboBox();
            label2 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            txtLocalidad = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            lstEmpleados = new ListBox();
            txtSalario = new TextBox();
            label6 = new Label();
            txtOficio = new TextBox();
            label7 = new Label();
            txtApellido = new TextBox();
            label8 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(29, 48);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(185, 28);
            cmbDepartamentos.TabIndex = 1;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 89);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(29, 112);
            txtId.Name = "txtId";
            txtId.Size = new Size(185, 27);
            txtId.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(29, 174);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(185, 27);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 151);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(29, 236);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(185, 27);
            txtLocalidad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 213);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 6;
            label4.Text = "Localidad";
            // 
            // button1
            // 
            button1.Location = new Point(29, 287);
            button1.Name = "button1";
            button1.Size = new Size(185, 56);
            button1.TabIndex = 8;
            button1.Text = "Insertar Departamento";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(248, 25);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 9;
            label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(248, 48);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(319, 384);
            lstEmpleados.TabIndex = 10;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(591, 236);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(185, 27);
            txtSalario.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(591, 213);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 15;
            label6.Text = "Salario";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(591, 174);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(185, 27);
            txtOficio.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(591, 151);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 13;
            label7.Text = "Oficio";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(591, 112);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(185, 27);
            txtApellido.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(591, 89);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 11;
            label8.Text = "Apellido";
            // 
            // button2
            // 
            button2.Location = new Point(591, 287);
            button2.Name = "button2";
            button2.Size = new Size(185, 56);
            button2.TabIndex = 17;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // PracticaEmpleadosDepartamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(txtSalario);
            Controls.Add(label6);
            Controls.Add(txtOficio);
            Controls.Add(label7);
            Controls.Add(txtApellido);
            Controls.Add(label8);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(txtLocalidad);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Name = "PracticaEmpleadosDepartamento";
            Text = "PracticaEmpleadosDepartamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepartamentos;
        private Label label2;
        private TextBox txtId;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtLocalidad;
        private Label label4;
        private Button button1;
        private Label label5;
        private ListBox lstEmpleados;
        private TextBox txtSalario;
        private Label label6;
        private TextBox txtOficio;
        private Label label7;
        private TextBox txtApellido;
        private Label label8;
        private Button button2;
    }
}