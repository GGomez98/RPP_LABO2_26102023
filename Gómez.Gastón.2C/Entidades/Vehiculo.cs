namespace Entidades
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

        protected string Tipo
        {
            get { return this.GetType().ToString(); }
        }
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

        protected virtual string GetInfo()
        {
            string siNoEsAWD;

            if (this.esAWD)
            {
                siNoEsAWD = "Si";
            }
            else
            {
                siNoEsAWD = "No";
            }
                return $"{this.Tipo} con propulsión a {this.Propulsion}, {siNoEsAWD} numero de chasis {this.numeroDeChasis}. ";
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