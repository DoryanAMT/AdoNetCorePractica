﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetCorePractica.Models
{
    public class Empleado
    {
        public int EmpNo { get; set; }
        public string Apellido { get; set; }
        public string Funcion { get; set; }
        public int Salario { get; set; }
    }
}
