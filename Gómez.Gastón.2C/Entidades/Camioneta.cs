using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;

        protected string Tipo
        {
            get
            {
                return "Camioneta";
            }
        }
        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(propulsion)
        {
            this.cabinaSimple = cabinaSimple;
            this.esAWD = true;
        }

        protected override string GetInfo()
        {
            string tipoCabina;
            StringBuilder sb = new StringBuilder();

            if (this.cabinaSimple)
            {
                tipoCabina = "Simple";
            }
            else
            {
                tipoCabina = "Doble";
            }

            sb.Append(base.ToString());
            sb.Append($"Con cabina: {tipoCabina}.");

            return sb.ToString();
        }
    }
}
