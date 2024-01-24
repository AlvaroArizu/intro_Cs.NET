namespace WinFormsApp2
{
    public partial class lblNombre : Form
    {
        public lblNombre()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
            string nombre =  txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;
            lblResultado.Text = "Nombre y Apellido es: " + nombre + " " + apellido + ", edad: " + edad;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtNombre.Clear();
            txtEdad.Clear();
            lblResultado.Text = "";

            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir de la app?", "Salir de la app", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(opcion == DialogResult.Yes)
            {
                Close();
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
