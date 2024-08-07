using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpbibliotecaBD
{
    public partial class frmwModificar : Form
    {
        public frmwModificar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            bool textoCorrecto = true;
            bool numeroCorrecto = true;
            int id;
            id = Convert.ToInt32(txtbIdModificar.Text.Trim());
            if (!int.TryParse(txtbIdModificar.Text.Trim(), out id))
            {
                numeroCorrecto = false;
            }
            if (txtbTituloNuevo.Text.Trim() == "")
            {
                textoCorrecto = false;
            }
            if (txtbAutorNuevo.Text.Trim() == "")
            {
                textoCorrecto = false;
            }
            if (txtbEditorialNueva.Text.Trim() == "")
            {
                textoCorrecto = false;
            }
            if (txtbGeneroNuevo.Text.Trim() == "")
            {
                textoCorrecto = false;
            }
            int Ubi;
            if (!int.TryParse(txtbUbicacionNueva.Text.Trim(), out Ubi))
            {
                numeroCorrecto = false;
            }

            int nro2;
            if (!int.TryParse(txtbCopiasNuevas.Text.Trim(), out nro2))
            {
                numeroCorrecto = false;
            }
            if (textoCorrecto == false) { MessageBox.Show("Ingrese todos los campos"); }
            if (numeroCorrecto == false) { MessageBox.Show("Ingrese un número en los campos 'ubicación', 'copias' y 'Id'"); }
            if (textoCorrecto && numeroCorrecto)
            {
                DialogResult Update = MessageBox.Show("¿Estás seguro de modificar este libro?", "ADVERTENCIA:", MessageBoxButtons.YesNo);
                if (Update == DialogResult.Yes)
                {
                    Libros LibroModificado = new Libros(txtbTituloNuevo.Text.Trim(), txtbAutorNuevo.Text.Trim(), txtbEditorialNueva.Text.Trim(), txtbGeneroNuevo.Text.Trim(), Convert.ToInt32(txtbUbicacionNueva.Text.Trim()), Convert.ToInt32(txtbCopiasNuevas.Text.Trim()));
                    if (LibroModificado.Update(id))
                    {
                        MessageBox.Show("Guardado con exito.");
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar los datos.");
                    }
                }

            }
        }
    }
}
