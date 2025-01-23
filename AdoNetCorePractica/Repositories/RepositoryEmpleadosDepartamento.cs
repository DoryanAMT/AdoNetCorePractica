using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCorePractica.Models;
using Microsoft.Data.SqlClient;
using System.Data;

#region
//create procedure SP_ALL_DEPARTAMENTOS
//as
//	select * from DEPT
//go
//create procedure SP_GET_EMPLEADOS_DEPARTAMENTO
//(@nombre as nvarchar(50))
//as
//	declare @deptcod as int
//	select @deptcod = DEPT_NO from DEPT
//	where DNOMBRE = @nombre
//	select EMP.APELLIDO from EMP
//	inner join DEPT
//	on EMP.DEPT_NO = DEPT.DEPT_NO
//	where EMP.DEPT_NO = @deptcod
//go
#endregion

namespace AdoNetCorePractica.Repositories
{
    internal class RepositoryEmpleadosDepartamento
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryEmpleadosDepartamento()
        {
            string connectionString =
                Helpers.HelpersConfiguration.GetConnectionString();
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<Departamento>> GetDepartamentoAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Departamento> departamentos = new List<Departamento>();
            while (await this.reader.ReadAsync())
            {
                Departamento departamento = new Departamento();
                string dnombre = this.reader["DNOMBRE"].ToString();
                departamento.Dnombre = dnombre;
                departamentos.Add(departamento);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return departamentos;
        }

        // necesito el modelo de los empleados del departamento oara poder pintarlo en el lstEmpleados
        public async Task<List<Empleado>> GetEmpleadosDepartamentoAsync
            (string nombre)
        {
            string sql = "SP_GET_EMPLEADOS_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<Empleado> empleados = new List<Empleado>();
            while (await this.reader.ReadAsync())
            {
                Empleado empleado = new Empleado();
                string apellido = this.reader["APELLIDO"].ToString();
                empleado.Apellido = apellido;
                empleados.Add(empleado);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return empleados;
        }

        public async Task InsertDepartamentoAsync
            (int deptno, string dnombre, string loc)
        {
            string sql = "SP_INSERT_DEPARTAMENTO";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.com.Parameters.AddWithValue("@deptno", deptno);
            this.com.Parameters.AddWithValue("@dnombre", dnombre);
            this.com.Parameters.AddWithValue("@loc", loc);
            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
