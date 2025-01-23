using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCorePractica.Helpers;
using Microsoft.Data.SqlClient;
using System.Data;
using AdoNetCorePractica.Models;
using System.Diagnostics.Metrics;

#region
//create procedure sp_gethospitales
//as
//	select nombre from hospital
//go
//create procedure sp_empleados_hospital_out
//(@nombre nvarchar(50), @suma int out, @media int out, @personas int out)
//as
//	select * from v_empleados_hospital
//	where nombre = @nombre
//	select @suma = sum(salario), @media = avg(salario),
//    @personas = count(apellido) from v_empleados_hospital
//	where nombre = @nombre
//go
//create view v_empleados_hospital
//as
//select doctor.apellido, doctor.especialidad, doctor.salario,
//doctor.hospital_cod, hospital.nombre
//from doctor
//inner join hospital
//on doctor.hospital_cod = hospital.hospital_cod
//union
//select plantilla.apellido, plantilla.funcion, plantilla.salario,
//plantilla.hospital_cod, hospital.nombre
//from plantilla
//inner join hospital
//on plantilla.hospital_cod = hospital.hospital_cod
//go
#endregion

namespace AdoNetCorePractica.Repositories
{
    public class RepositoryHospitalPlantilla
    {
        //  declaramos los 3 objetos que usaremos
        //  para conectarnos a la base de datos cn,
        //  para realizar comandos en sql com y
        //  para leer lo que nos devuelve la consola reader;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryHospitalPlantilla()
        {
            string connectionString =
                HelpersConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<Hospital> GetHospitalesAsync()
        {
            string sql = "SP_GETHOSPITALES";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            Hospital datos = new Hospital();
            List<string> hospitales = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                hospitales.Add(nombre);
            }
            datos.Nombre = hospitales;
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return datos;
        }

        public async Task<PlantillaHospitalOut> GetPlantillaHospitalAsync
            (string nombre)
        {
            string sql = "SP_EMPLEADOS_HOSPITAL_OUT";
            this.com.Parameters.AddWithValue("@nombre", nombre);
            
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@suma";
            pamSuma.Value = 0;
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);

            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@media";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);

            SqlParameter numEmpleados = new SqlParameter();
            numEmpleados.ParameterName = "@personas";
            numEmpleados.Value = 0;
            numEmpleados.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(numEmpleados);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            PlantillaHospitalOut datos = new PlantillaHospitalOut();
            List<Empleado> empleados = new List<Empleado>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string funcion = this.reader["ESPECIALIDAD"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                Empleado empleado = new Empleado();
                empleado.Apellido = apellido;
                empleado.Funcion = funcion;
                empleado.Salario = salario;
                empleados.Add(empleado);
            }

            await this.reader.CloseAsync();

            datos.Empleados = empleados;
            datos.SumaSalarial = int.Parse(pamSuma.Value.ToString());
            datos.MediaSalarial = int.Parse(pamMedia.Value.ToString());
            datos.NumEmpleados = int.Parse(numEmpleados.Value.ToString());

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return datos;
        }
    }
}
