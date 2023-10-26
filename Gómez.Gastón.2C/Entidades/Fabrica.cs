using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public List<Vehiculo> Vehiculos { get { return vehiculos; } }

        private Fabrica() 
        { 
            this.vehiculos = new List<Vehiculo>();
        }
        public Fabrica(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        public static Fabrica operator +(Fabrica fabrica, Vehiculo vehiculo)
        {
            if (fabrica.vehiculos.Count() < fabrica.capacidad)
            {
                fabrica.vehiculos.Add(vehiculo);
            }

            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            foreach(Vehiculo vehiculoEnFabrica in fabrica.vehiculos)
            {
                if(vehiculoEnFabrica == vehiculo)
                {
                    fabrica.vehiculos.Remove(vehiculoEnFabrica);
                    break;
                }
            }

            return fabrica;
        }
    }
}
