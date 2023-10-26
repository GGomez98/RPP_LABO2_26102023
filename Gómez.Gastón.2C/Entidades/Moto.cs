﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        public string Tipo
        {
            get
            {
                return "Moto";
            }
        }
        public Moto(EPropulsion propulsion) : base(propulsion)
        {
        }
    }
}
