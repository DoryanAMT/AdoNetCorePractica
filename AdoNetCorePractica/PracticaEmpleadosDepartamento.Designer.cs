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
            txtIdDepartamento = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            txtLocalidad = new TextBox();
            label4 = new Label();
            btnInsertDepartamento = new Button();
            label5 = new Label();
            lstEmpleados = new ListBox();
            txtSalario = new TextBox();
            label6 = new Label();
            txtOficio = new TextBox();
            label7 = new Label();
            txtApellido = new TextBox();
            label8 = new Label();
            btnUpdateEmpleado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cmbDepartamentos
            // 
            cmbDepartamentos.FormattingEnabled = true;
            cmbDepartamentos.Location = new Point(25, 36);
            cmbDepartamentos.Margin = new Padding(3, 2, 3, 2);
            cmbDepartamentos.Name = "cmbDepartamentos";
            cmbDepartamentos.Size = new Size(162, 23);
            cmbDepartamentos.TabIndex = 1;
            cmbDepartamentos.SelectedIndexChanged += cmbDepartamentos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 67);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // txtIdDepartamento
            // 
            txtIdDepartamento.Location = new Point(25, 84);
            txtIdDepartamento.Margin = new Padding(3, 2, 3, 2);
            txtIdDepartamento.Name = "txtIdDepartamento";
            txtIdDepartamento.Size = new Size(162, 23);
            txtIdDepartamento.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(25, 130);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(162, 23);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 113);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(25, 177);
            txtLocalidad.Margin = new Padding(3, 2, 3, 2);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(162, 23);
            txtLocalidad.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 160);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "Localidad";
            // 
            // btnInsertDepartamento
            // 
            btnInsertDepartamento.Location = new Point(25, 215);
            btnInsertDepartamento.Margin = new Padding(3, 2, 3, 2);
            btnInsertDepartamento.Name = "btnInsertDepartamento";
            btnInsertDepartamento.Size = new Size(162, 42);
            btnInsertDepartamento.TabIndex = 8;
            btnInsertDepartamento.Text = "Insertar Departamento";
            btnInsertDepartamento.UseVisualStyleBackColor = true;
            btnInsertDepartamento.Click += btnInsertDepartamento_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 19);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 9;
            label5.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(217, 36);
            lstEmpleados.Margin = new Padding(3, 2, 3, 2);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(280, 289);
            lstEmpleados.TabIndex = 10;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(517, 177);
            txtSalario.Margin = new Padding(3, 2, 3, 2);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(162, 23);
            txtSalario.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(517, 160);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 15;
            label6.Text = "Salario";
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(517, 130);
            txtOficio.Margin = new Padding(3, 2, 3, 2);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(162, 23);
            txtOficio.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(517, 113);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 13;
            label7.Text = "Oficio";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(517, 84);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(162, 23);
            txtApellido.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(517, 67);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 11;
            label8.Text = "Apellido";
            // 
            // btnUpdateEmpleado
            // 
            btnUpdateEmpleado.Location = new Point(517, 215);
            btnUpdateEmpleado.Margin = new Padding(3, 2, 3, 2);
            btnUpdateEmpleado.Name = "btnUpdateEmpleado";
            btnUpdateEmpleado.Size = new Size(162, 42);
            btnUpdateEmpleado.TabIndex = 17;
            btnUpdateEmpleado.Text = "Update";
            btnUpdateEmpleado.UseVisualStyleBackColor = true;
            // 
            // PracticaEmpleadosDepartamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnUpdateEmpleado);
            Controls.Add(txtSalario);
            Controls.Add(label6);
            Controls.Add(txtOficio);
            Controls.Add(label7);
            Controls.Add(txtApellido);
            Controls.Add(label8);
            Controls.Add(lstEmpleados);
            Controls.Add(label5);
            Controls.Add(btnInsertDepartamento);
            Controls.Add(txtLocalidad);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(txtIdDepartamento);
            Controls.Add(label2);
            Controls.Add(cmbDepartamentos);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PracticaEmpleadosDepartamento";
            Text = "PracticaEmpleadosDepartamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDepartamentos;
        private Label label2;
        private TextBox txtIdDepartamento;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtLocalidad;
        private Label label4;
        private Button btnInsertDepartamento;
        private Label label5;
        private ListBox lstEmpleados;
        private TextBox txtSalario;
        private Label label6;
        private TextBox txtOficio;
        private Label label7;
        private TextBox txtApellido;
        private Label label8;
        private Button btnUpdateEmpleado;
    }
}