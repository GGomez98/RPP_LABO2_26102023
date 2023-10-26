using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        public string Tipo
        {
            get
            {
                return "Automovil";
            }
        }

        public Automovil():base(EPropulsion.Hidrica)
        {
        }
    }
}
