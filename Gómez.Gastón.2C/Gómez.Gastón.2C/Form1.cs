using Entidades;

namespace Gómez.Gastón._2C
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
            InicializarFabrica();
            Refrescar();
        }

        private void btnEliminar_CLick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {

        }

        private void InicializarFabrica()
        {
            fabrica = new Entidades.Fabrica(10);
            Camioneta camioneta = new Camioneta(EPropulsion.Electrica, true);
            fabrica += camioneta;
        }

        private void Refrescar()
        {
            lstVehiculos.DataSource = null;
            foreach (Vehiculo vehiculo in fabrica.Vehiculos)
            {
                lstVehiculos.Items.Add(vehiculo.ToString());
            }
        }
    }
}