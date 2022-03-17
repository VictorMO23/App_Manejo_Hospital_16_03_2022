using System;
using System.Windows.Forms;
using Negocio;

namespace Presentación
{
    public partial class FrmPacientes : Form
    {
        clsPacientes[] pacientes = new clsPacientes[1000];
        int sw = 0;
        int pos = 0, encuentra = 0;
        
        public FrmPacientes()
        {
            InitializeComponent();
            cbmSexo.SelectedIndex = 0;
        }

        private void ptbBuscar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Debe ingresar la identificación a consultar");
                txtID.Focus();
            }
            else
            {
                sw = 0;
                encuentra = 0;
                for (int i = 0; i < pos; i++)
                {
                    if (Convert.ToInt32(txtID.Text) == pacientes[i].getID())
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
                        txtID.Text = "" + pacientes[encuentra].getID();
                        txtNombre.Text = pacientes[encuentra].getNombre();
                        txtEps.Text = pacientes[encuentra].getEps();
                        txtContacto.Text = "" + pacientes[encuentra].getContacto();
                        txtDireccion.Text = pacientes[encuentra].getDireccion();
                        cbmSexo.SelectedIndex = pacientes[encuentra].getSexo();
                        txtAntecedentes.Text = pacientes[encuentra].getAntecedentes();
                    }
                
            }
        }

        private void ptbActualizar_Click(object sender, EventArgs e)
        {
            if (txtContacto.Text == "" || txtEps.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("No se pudo realizar la actualización con éxito");
            }
            else
            {
                pacientes[encuentra].SetContacto(Convert.ToDouble(txtContacto.Text));
                pacientes[encuentra].SetEps(txtEps.Text);
                pacientes[encuentra].SetDirección(txtDireccion.Text);
                MessageBox.Show("La información se ha actualizado con éxito" + "\n\n" + 
                    "Solo se permite actualizar el contacto, eps y dirección");

            }
        }

        private void ptbGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNombre.Text == "" || txtEps.Text == "" || txtContacto.Text == "" ||
                txtDireccion.Text == "" || cbmSexo.SelectedIndex != 1 && cbmSexo.SelectedIndex != 2 || txtAntecedentes.Text == "" )
            {
                MessageBox.Show("Debe ingresar toda la información solicitada");
            }
            else
            {
                sw = 0;
                for (int i = 0; i < pos; i++)
                {
                    if (Convert.ToInt32(txtID.Text) == pacientes[i].getID())
                    {
                        sw = 1;
                    }
                }
                if (sw == 0)
                {
                    pacientes[pos] = new clsPacientes(
                        Convert.ToInt32(txtID.Text), txtNombre.Text,txtEps.Text, Convert.ToDouble(txtContacto.Text),
                        txtDireccion.Text, cbmSexo.SelectedIndex, txtAntecedentes.Text);
                    MessageBox.Show("Datos almacenados con éxito");
                    pos++;
                }
                else
                {
                    MessageBox.Show("Esta persona ya se encuentra registrada");
                }

            }
        }


    }
}
