using System;
using Negocio;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FrmCitas : Form
    {
        clsCitas[] objCitas = new clsCitas[1000];
        int sw = 0;
        int encuentra = 0, pos = 0;
        public FrmCitas()
        {
            InitializeComponent();
            int lblNo_citas = pos;
        }

        private void ptbBuscar_Click(object sender, EventArgs e)
        {
            if (txtID_Paciente.Text == "")
            {
                MessageBox.Show("Debe ingresar la identificación del paciente a consultar");
                txtID_Paciente.Focus();
            }
            else
            {
                sw = 0;
                encuentra = 0;
                for (int i = 0; i < pos; i++)
                {
                    if (Convert.ToInt32(txtID_Paciente.Text) == objCitas[i].getId_paciente())
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
                    txtCodigo_Medico.Text = "" + objCitas[encuentra].getCod_Medico();
                    txtID_Paciente.Text = "" + objCitas[encuentra].getId_paciente();
                    txtFecha.Text = "" + objCitas[encuentra].getFecha();
                    txtMotivo.Text = objCitas[encuentra].getMotivo();
                }

            }
        }

        private void ptbGuardar_Click(object sender, EventArgs e)
        {
            if (txtID_Paciente.Text == "" || txtCodigo_Medico.Text == "" ||
                txtFecha.Text == "" || txtMotivo.Text == "")
            {
                MessageBox.Show("Debe ingresar toda la información solicitada");
            }
            else
            {
                sw = 0;
                for (int i = 0; i < pos; i++)
                {
                    if (Convert.ToInt32(txtID_Paciente.Text) == objCitas[i].getId_paciente())
                    {
                        sw = 1;
                    }
                }
                if (sw == 0)
                {
                    objCitas[pos] = new clsCitas(
                        Convert.ToInt32(lblNo_Citas.Text), Convert.ToInt32(txtID_Paciente.Text),
                        Convert.ToInt32(txtCodigo_Medico.Text), Convert.ToInt32(txtFecha.Text),
                        txtMotivo.Text);
                    MessageBox.Show("Datos almacenados con éxito");
                    pos++;
                }
                else
                {
                    MessageBox.Show("Esta paciente ya tiene su cita registrada");
                }
            }
        }
    }
}
