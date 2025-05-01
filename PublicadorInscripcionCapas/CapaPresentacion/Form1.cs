using CapaAdaptador;
using CapaNegocio;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public partial class Inscripciones : Form
    {
        public Inscripciones()
        {
            InitializeComponent();

            cbCarrera.SelectedIndex = 0;
        }

        private void Inscripciones_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarInscripcionAsync();
        }

        private async Task EnviarInscripcionAsync()
        {
            string name = txtName.Text;
            string lastname = txtLastName.Text;
            string nroId = txtIdentification.Text;
            string option = cbCarrera.SelectedItem.ToString();

            InscripcionDTO inscripcion = new InscripcionDTO(name, lastname, nroId, option);

            AdaptadorRabbit adaptador = await AdaptadorRabbit.CreateAsync();
            adaptador.EnviarInscripcion(inscripcion);
            MessageBox.Show("Se ha enviado la informacion", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
