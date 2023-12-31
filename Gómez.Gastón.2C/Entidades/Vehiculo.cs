﻿namespace Entidades
{
    public enum EPropulsion
    {
        Combustion,
        Hidrica,
        Electrica
    }
    public abstract class Vehiculo
    {
        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        public EPropulsion Propulsion
        {
            get { return propulsion; }
        }

        protected abstract string Tipo { get; }
        protected Vehiculo(EPropulsion propulsion) 
        {
            this.propulsion = propulsion;
            this.esAWD = false;
            this.numeroDeChasis = Guid.NewGuid();
        }

        protected Vehiculo(EPropulsion propulsion, bool esAWD): this(propulsion)
        {
            this.esAWD = esAWD;
        }

        /// <summary>
        /// Obtiene la informacion del vehiculo
        /// </summary>
        /// <returns>Una cadena de caracteres con la informacion del vehiculo</returns>
        protected virtual string GetInfo()
        {
            string siNoEsAWD;
            string tipoPropulsion;

            if (this.esAWD)
            {
                siNoEsAWD = "Si";
            }
            else
            {
                siNoEsAWD = "No";
            }

            switch (this.propulsion)
            {
                case EPropulsion.Electrica:
                    tipoPropulsion = "Electrica";
                    break;
                case EPropulsion.Combustion:
                    tipoPropulsion = "Combustion";
                    break;
                default:
                    tipoPropulsion = "Hidrica";
                    break;
            }
                return $"{this.Tipo} con propulsión a {tipoPropulsion}, {siNoEsAWD} numero de chasis {this.numeroDeChasis}. ";
        }

        public string ToString()
        {
            return this.GetInfo() ;
        }

        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            return v1.Tipo == v2.Tipo && v1.numeroDeChasis == v2.numeroDeChasis;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return v1.Tipo != v2.Tipo || v1.numeroDeChasis != v2.numeroDeChasis;
        }
    }
}