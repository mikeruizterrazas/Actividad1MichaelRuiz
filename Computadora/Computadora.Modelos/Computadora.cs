﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Modelos
{
    public class Computadora
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Decimal precio { get; set; }
        public DateTime fecha { get; set; }
    }
}

