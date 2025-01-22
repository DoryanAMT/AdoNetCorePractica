using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

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
        }


    }
}
