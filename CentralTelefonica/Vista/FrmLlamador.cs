using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralTelefonica;
namespace Vista
{
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        List<int> numeroDiscado = new List<int>();
        bool secuencia = true;

        public FrmLlamador()
        {
            InitializeComponent();
            centralita = new Centralita("Gonza ContactCenter");
        }


        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        public Centralita Centralita
        {
            get { return centralita; }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.Items.Add("Franja_1");
            cmbFranja.Items.Add("Franja_2");
            cmbFranja.Items.Add("Franja_3");
        }


        private void Btn_Click(object sender, EventArgs e)
        {

        }


        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {


        }

        private void AgregarNumero(string numero)
        {
            txtNroDestino.Text += numero;
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtNroDestino.Text = "";
                txtNroDestino.Text = "1";
                secuencia = false;
            }
            else
            {
                txtNroDestino.Text = txtNroDestino.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtNroDestino.Text = "";
                txtNroDestino.Text = "2";
                secuencia = false;
            }
            else
            {
                txtNroDestino.Text = txtNroDestino.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtNroDestino.Text = "";
                txtNroDestino.Text = "3";
                secuencia = false;
            }
            else
            {
                txtNroDestino.Text = txtNroDestino.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtNroDestino.Text = "";
                txtNroDestino.Text = "4";
                secuencia = false;
            }
            else
            {
                txtNroDestino.Text = txtNroDestino.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtNroDestino.Text = "";
                txtNroDestino.Text = "5";
                secuencia = false;
            }
            else
            {
                txtNroDestino.Text = txtNroDestino.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtNroDestino.Text = "";
                txtNroDestino.Text = "6";
                secuencia = false;
            }
            else
            {
                txtNroDestino.Text = txtNroDestino.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtNroDestino.Text = "";
                txtNroDestino.Text = "7";
                secuencia = false;
            }
            else
            {
                txtNroDestino.Text = txtNroDestino.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtNroDestino.Text = "";
                txtNroDestino.Text = "8";
                secuencia = false;
            }
            else
            {
                txtNroDestino.Text = txtNroDestino.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtNroDestino.Text = "";
                txtNroDestino.Text = "9";
                secuencia = false;
            }
            else
            {
                txtNroDestino.Text = txtNroDestino.Text + "9";
            }
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtNroDestino.Text = "";
                txtNroDestino.Text = "*";
                secuencia = false;
            }
            else
            {
                txtNroDestino.Text = txtNroDestino.Text + "*";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtNroDestino.Text = "";
                txtNroDestino.Text = "0";
                secuencia = false;
            }
            else
            {
                txtNroDestino.Text = txtNroDestino.Text + "0";
            }
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtNroDestino.Text = "";
                txtNroDestino.Text = "#";
                secuencia = false;
            }
            else
            {
                txtNroDestino.Text = txtNroDestino.Text + "#";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Provincial llamadaProvincia;
            Local llamadaLocal;
            Random random = new Random();

            if (txtNroDestino.Text != "")
            {
                if (txtNroDestino.Text.StartsWith("#"))
                {
                    if (cmbFranja.SelectedItem.ToString() == "Franja_1")
                    {
                        try
                        {
                            llamadaProvincia = new Provincial(txtNroOrigen.Text, Provincial.eFranja.Franja_1, random.Next(1, 50), txtNroDestino.Text);
                             centralita +=llamadaProvincia;
                            MessageBox.Show($"{llamadaProvincia.ToString()}");
                        }catch(LaCentralitaException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                    }else if(cmbFranja.SelectedItem.ToString() == "Franja_2")
                    {
                        llamadaProvincia = new Provincial(txtNroOrigen.Text, Provincial.eFranja.Franja_2, random.Next(1, 50), txtNroDestino.Text);
                         centralita += llamadaProvincia;
                        MessageBox.Show($"{llamadaProvincia.ToString()}");
                    }
                    else if (cmbFranja.SelectedItem.ToString() == "Franja_3")
                    {
                        llamadaProvincia = new Provincial(txtNroOrigen.Text, Provincial.eFranja.Franja_3, random.Next(1, 50), txtNroDestino.Text);
                        centralita += llamadaProvincia;
                        
                        MessageBox.Show($"{llamadaProvincia.ToString()}");
                    }


                }
                else
                {
                    llamadaLocal = new Local(txtNroOrigen.Text, random.Next(10, 20), random.Next(1, 50), txtNroDestino.Text);
                    centralita += llamadaLocal;
                    MessageBox.Show($"{llamadaLocal.ToString()}");
                }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
