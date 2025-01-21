using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCorePractica.Helpers
{
    public class HelpersConfiguration
    {
        public static void GetConnectionString()
        {
            //  NECESITAMOS UN CONSTRUCTOR DE CONFIGURACIONES
            ConfigurationBuilder builder = new ConfigurationBuilder();
            //  EN ESTE ENTORNO NO ES NATIVO, POR LO QUE DEBEMOS
            //  INDICAR DE FORMA EXPLICITA EL NOMBRE DEL FICHERO
            //  SU UBICACION
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            //  EL OBJETO PARA RECUPERAR LAS KEYS
            IConfigurationRoot configuration = builder.Build();
            //  EXISTE CLAVES QUE YA VIENEN POR DEFECTO: ConnectionString
            string connectionString = configuration.GetConnectionString("SqlTajamar");
            return connectionString;
        }
    }
}
