using System;
using Negocio;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FrmMedicos : Form
    {
        clsMedicos[] ObjMedicos = new clsMedicos[1000];
        int sw = 0;
        int pos = 0, encuentra = 0;

        public FrmMedicos()
        {
            InitializeComponent();
            cmbSexo.SelectedIndex = 0;
        }

        private void ptbGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtContacto.Text == "" || cmbSexo.SelectedIndex != 1 && cmbSexo.SelectedIndex != 2)
            {
                MessageBox.Show("Debe ingresar toda la información solicitada");
            }
            else
            {
                sw = 0;
                for (int i = 0; i < pos; i++)
                {
                    if (Convert.ToInt32(txtCodigo.Text) == ObjMedicos[i].getCodigo())
                    {
                        sw = 1;
                    }
                }
                if (sw == 0)
                {
                    ObjMedicos[pos] = new clsMedicos(
                        Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToDouble(txtContacto.Text),
                        cmbSexo.SelectedIndex);
                    MessageBox.Show("Datos almacenados con éxito");
                     pos++;
                }
                else
                {
                    MessageBox.Show("Este codigo de medico ya se encuentra registrada");
                }
            }
        }

        private void ptbBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar el código del medico a consultar");
                txtCodigo.Focus();
            }
            else
            {
                sw = 0;
                encuentra = 0;
                for (int i = 0; i < pos; i++)
                {
                    if (Convert.ToInt32(txtCodigo.Text) == ObjMedicos[i].getCodigo())
                    {
                        sw = 1;
                        encuentra = i;
                    }
                }
                if (sw == 0)
                {
                    MessageBox.Show("No se encontraron registros");
                }
                else
                {
                    txtCodigo.Text = "" + ObjMedicos[encuentra].getCodigo();
                    txtNombre.Text = ObjMedicos[encuentra].getNombre();
                    txtContacto.Text = "" + ObjMedicos[encuentra].getContacto();
                    cmbSexo.SelectedIndex = ObjMedicos[encuentra].getSexo();
                }

            }
        }
    }
}
