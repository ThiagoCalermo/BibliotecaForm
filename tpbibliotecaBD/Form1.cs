using System.Data;

namespace tpbibliotecaBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void llenar(DataTable dt)
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = dt;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Libros.SearchAll();
            llenar(dt);
        }
        public DataTable Mostrar()
        {
            DataTable dt = new DataTable();
            return dt;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bool textoCorrecto = true;
            bool numeroCorrecto = true;
            if (txtbTitulo.Text.Trim() == "")
            {
                textoCorrecto = false;
            }
            if (txtbAutor.Text.Trim() == "")
            {
                textoCorrecto = false;
            }
            if (txtbEditorial.Text.Trim() == "")
            {
                textoCorrecto = false;
            }
            if (txtbGenero.Text.Trim() == "")
            {
                textoCorrecto = false;
            }
            int Ubi;
            if (!int.TryParse(txtbUbicacion.Text.Trim(), out Ubi))
            {
                numeroCorrecto = false;
            }

            int nro2;
            if (!int.TryParse(txtbCopiasDis.Text.Trim(), out nro2))
            {
                numeroCorrecto = false;
            }
            if (textoCorrecto == false) { MessageBox.Show("Ingrese todos los campos"); }
            if (numeroCorrecto == false) { MessageBox.Show("Ingrese un número en los campos 'ubicación' y 'copias'"); }
            if (textoCorrecto && numeroCorrecto)
            {
                Libros libroNuevo = new Libros(txtbTitulo.Text.Trim(), txtbAutor.Text.Trim(), txtbEditorial.Text.Trim(), txtbGenero.Text.Trim(), Convert.ToInt32(txtbUbicacion.Text.Trim()), Convert.ToInt32(txtbCopiasDis.Text.Trim()));
                if (libroNuevo.New())
                {
                    MessageBox.Show("Guardado con exito.");
                }
                else
                {
                    MessageBox.Show("Error al guardar los datos.");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmwModificar nuevoForm = new frmwModificar();
            nuevoForm.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvLibros.CurrentRow.Cells[0].Value);
                DialogResult borrar = MessageBox.Show("¿Está seguro?", "ADVERTENCIA:", MessageBoxButtons.YesNo);
                if (borrar == DialogResult.Yes)
                {
                    Libros.Clear(id);
                    MessageBox.Show("Libro borrado con exito");

                }
            }
            else
            {
                MessageBox.Show("!Seleccione un libro para borrar¡");
            }
        }
    }
}