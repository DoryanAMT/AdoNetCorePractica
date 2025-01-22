namespace AdoNetCorePractica
{
    partial class practicaHospitales
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
            label2 = new Label();
            label3 = new Label();
            cmbHospitales = new ComboBox();
            lstEmpleadosHospital = new ListBox();
            label4 = new Label();
            label5 = new Label();
            txtSumaSalarial = new TextBox();
            txtMediaSalarial = new TextBox();
            txtPersonas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 31);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 31);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 1;
            label2.Text = "Empleados Hospital";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 117);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "Suma Salarial";
            // 
            // cmbHospitales
            // 
            cmbHospitales.FormattingEnabled = true;
            cmbHospitales.Location = new Point(30, 54);
            cmbHospitales.Name = "cmbHospitales";
            cmbHospitales.Size = new Size(170, 28);
            cmbHospitales.TabIndex = 3;
            cmbHospitales.SelectedIndexChanged += cmbHospitales_SelectedIndexChanged;
            // 
            // lstEmpleadosHospital
            // 
            lstEmpleadosHospital.FormattingEnabled = true;
            lstEmpleadosHospital.Location = new Point(275, 54);
            lstEmpleadosHospital.Name = "lstEmpleadosHospital";
            lstEmpleadosHospital.Size = new Size(340, 344);
            lstEmpleadosHospital.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 182);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 5;
            label4.Text = "Media Salarial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 246);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 6;
            label5.Text = "Personas";
            // 
            // txtSumaSalarial
            // 
            txtSumaSalarial.Location = new Point(30, 140);
            txtSumaSalarial.Name = "txtSumaSalarial";
            txtSumaSalarial.Size = new Size(170, 27);
            txtSumaSalarial.TabIndex = 7;
            // 
            // txtMediaSalarial
            // 
            txtMediaSalarial.Location = new Point(30, 205);
            txtMediaSalarial.Name = "txtMediaSalarial";
            txtMediaSalarial.Size = new Size(170, 27);
            txtMediaSalarial.TabIndex = 8;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(30, 269);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(170, 27);
            txtPersonas.TabIndex = 9;
            // 
            // practicaHospitales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 450);
            Controls.Add(txtPersonas);
            Controls.Add(txtMediaSalarial);
            Controls.Add(txtSumaSalarial);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lstEmpleadosHospital);
            Controls.Add(cmbHospitales);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "practicaHospitales";
            Text = "practicaHospitales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbHospitales;
        private ListBox lstEmpleadosHospital;
        private Label label4;
        private Label label5;
        private TextBox txtSumaSalarial;
        private TextBox txtMediaSalarial;
        private TextBox txtPersonas;
    }
}