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
                int a�oTrimestre = (int)numericUpDownA�o.Value;

                Trimestre nuevoTrimestre = new Trimestre(idTrimestre, ntrimestre, new DateTime(a�oTrimestre, 1, 1));


            }
            else
            {

                MessageBox.Show("Trimestre agregado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnMostrarTrimestres_Click(object sender, EventArgs e)
        {

            // Muestra la informaci�n de cada trimestre en el ListBox
            foreach (Trimestre trimestre in lstTrimestres.Items)
            {
                if (trimestre is Trimestre)

                {
                    lstTrimestres.Items.Add($"ID: {trimestre.IdTrimestre}, N�mero: {trimestre.NTrimestre}, A�o {trimestre.A�o.Year}");
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


                    int a�oTrimestre = (int)numericUpDownA�o.Value;


                    // Crea un nuevo objeto Trimestre
                    Trimestre nuevoTrimestre = new Trimestre(idTrimestre, nTrimestre, new DateTime(a�oTrimestre, 1, 1));

                    // Agrega el trimestre a la lista
                    lstTrimestres.Items.Add(nuevoTrimestre);

                    // Opcional: Puedes mostrar un mensaje de �xito
                    MessageBox.Show("Trimestre agregado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show("Error: Selecciona un a�o v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                // Opcional: Puedes mostrar un mensaje de �xito
                MessageBox.Show("Trimestre agregado exitosamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}




