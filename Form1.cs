using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (int.TryParse(txtIdTrimestre.Text, out int idTrimestre) &&
              int.TryParse(txtNTrimestre.Text, out int ntrimestre))
            {
                int añoTrimestre = (int)numericUpDownAño.Value;

                Trimestre nuevoTrimestre = new Trimestre(idTrimestre, ntrimestre, new DateTime(añoTrimestre, 1, 1));


            }
            else
            {

                MessageBox.Show("Trimestre agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnMostrarTrimestres_Click(object sender, EventArgs e)
        {

            // Muestra la información de cada trimestre en el ListBox
            foreach (Trimestre trimestre in lstTrimestres.Items)
            {
                if (trimestre is Trimestre)

                {
                    lstTrimestres.Items.Add($"ID: {trimestre.IdTrimestre}, Número: {trimestre.NTrimestre}, Año {trimestre.Año.Year}");
                }

            }
        }
        private void listaTrimestres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarTrimestre_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtIdTrimestre.Text, out int idTrimestre) &&
                 int.TryParse(txtNTrimestre.Text, out int nTrimestre))
            {
                try
                {


                    int añoTrimestre = (int)numericUpDownAño.Value;


                    // Crea un nuevo objeto Trimestre
                    Trimestre nuevoTrimestre = new Trimestre(idTrimestre, nTrimestre, new DateTime(añoTrimestre, 1, 1));

                    // Agrega el trimestre a la lista
                    lstTrimestres.Items.Add(nuevoTrimestre);

                    // Opcional: Puedes mostrar un mensaje de éxito
                    MessageBox.Show("Trimestre agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Error: Selecciona un año válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                // Opcional: Puedes mostrar un mensaje de éxito
                MessageBox.Show("Trimestre agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}




