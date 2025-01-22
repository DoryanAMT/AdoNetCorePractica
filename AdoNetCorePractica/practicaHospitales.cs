using AdoNetCorePractica.Models;
using AdoNetCorePractica.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetCorePractica
{
    public partial class practicaHospitales : Form
    {
        RepositoryHospitalPlantilla repo;
        public practicaHospitales()
        {
            this.repo = new RepositoryHospitalPlantilla();
            InitializeComponent();
            this.LoadHospitales();
        }

        public async void LoadHospitales()
        {
            Hospital hospitales =
                await this.repo.GetHospitalesAsync();
            this.cmbHospitales.Items.Clear();
            foreach (string hospital in hospitales.Nombre)
            {
                this.cmbHospitales.Items.Add(hospital);
            }
        }

        private async void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbHospitales.SelectedIndex != -1)
            {
                string nombre = this.cmbHospitales.SelectedItem.ToString();
                PlantillaHospitalOut empleadosHospitalOut =
                    await this.repo.GetPlantillaHospitalAsync(nombre);
                this.lstEmpleadosHospital.Items.Clear();
                foreach (Empleado emp in empleadosHospitalOut.Empleados)
                {
                    this.lstEmpleadosHospital.Items.Add(emp.Apellido + " - " + emp.Funcion + " - " + emp.Salario);
                }
                this.txtSumaSalarial.Text = empleadosHospitalOut.SumaSalarial.ToString();
                this.txtMediaSalarial.Text = empleadosHospitalOut.MediaSalarial.ToString();
                this.txtPersonas.Text = empleadosHospitalOut.NumEmpleados.ToString();
            }
        }
    }
}
