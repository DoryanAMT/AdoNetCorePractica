using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCorePractica.Models
{
    public class PlantillaHospitalOut
    {
        public List<Empleado> Empleados { get; set; }
        public int SumaSalarial {get;set;}
        public int MediaSalarial { get; set; }
        public int NumEmpleados { get; set; }
    }
}
