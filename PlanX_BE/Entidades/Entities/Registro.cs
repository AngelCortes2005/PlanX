﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanXBackend.Entidades.Entities
{
    public class Registro
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public DateTime fecInicial { get; set; }
        public DateTime fecFinal { get; set; }
    }
}
