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
    public partial class PracticaEmpleadosDepartamento : Form
    {
        RepositoryEmpleadosDepartamento repo;
        public PracticaEmpleadosDepartamento()
        {
            this.repo = new RepositoryEmpleadosDepartamento();
            InitializeComponent();
            this.LoadDepartamentos();
        }
        public async Task LoadDepartamentos()
        {
            List<Departamento> departamentos =
                await this.repo.GetDepartamentoAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (Departamento dept in departamentos)
            {
                this.cmbDepartamentos.Items.Add(dept.Dnombre);
            }

        }

        private async Task LoadEmpleadosDepartamento
            (string deptnombre)
        {
            List<Empleado> empleados =
                await this.repo.GetEmpleadosDepartamentoAsync(deptnombre);
            this.lstEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.EmpNo + " - " + emp.Apellido
                    + " - " + emp.Funcion + " - " + emp.Salario);
            }
        }

        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departamento = this.cmbDepartamentos.SelectedItem.ToString();
            await this.LoadEmpleadosDepartamento(departamento);
            await this.LoadDepartamentos();
        }

        private async void btnInsertDepartamento_Click(object sender, EventArgs e)
        {
            int deptno = int.Parse(this.txtIdDepartamento.Text);
            string dnombre = this.txtNombre.Text;
            string loc = this.txtLocalidad.Text;
            await this.repo.InsertDepartamentoAsync(deptno, dnombre, loc);
            await this.LoadDepartamentos();
        }

        private async void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string empleadoSeleccionado = this.lstEmpleados.SelectedItem.ToString();
            string[] empleadoSeleccionadoWords = empleadoSeleccionado.Split(" - ");
            string apellido = empleadoSeleccionadoWords[1];
            string oficio = empleadoSeleccionadoWords[2];
            int salario = int.Parse(empleadoSeleccionadoWords[3]);
            this.txtApellido.Text = apellido;
            this.txtOficio.Text = oficio;
            this.txtSalario.Text = salario.ToString();
        }

        private async void btnUpdateEmpleado_Click(object sender, EventArgs e)
        {
            
            string empleadoSeleccionado = this.lstEmpleados.SelectedItem.ToString();
            string[] empleadoSeleccionadoWords = empleadoSeleccionado.Split(" - ");
            int empno = int.Parse(empleadoSeleccionadoWords[0]);
            string apellido = this.txtApellido.Text;
            string oficio = this.txtOficio.Text;
            int salario = int.Parse(this.txtSalario.Text);
            await this.repo.UpdateEmpleadoAsync(empno, apellido, oficio, salario);
        }
    }
}
