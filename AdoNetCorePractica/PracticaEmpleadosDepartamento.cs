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
        public async void LoadDepartamentos()
        {
            List<Departamento> departamentos =
                await this.repo.GetDepartamentoAsync();
            this.cmbDepartamentos.Items.Clear();
            foreach (Departamento dept in departamentos)
            {
                this.cmbDepartamentos.Items.Add(dept.Dnombre);
            }

        }
        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departamento = this.cmbDepartamentos.SelectedItem.ToString();
            List<Empleado> empleados =
                await this.repo.GetEmpleadosDepartamentoAsync(departamento);
            this.lstEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp.Apellido);
            }
            this.LoadDepartamentos();
        }

        private async void btnInsertDepartamento_Click(object sender, EventArgs e)
        {
            int deptno = int.Parse(this.txtIdDepartamento.Text);
            string dnombre = this.txtNombre.Text;
            string loc = this.txtLocalidad.Text;
            await this.repo.InsertDepartamentoAsync(deptno, dnombre, loc);
            this.LoadDepartamentos();
        }

        
    }
}
