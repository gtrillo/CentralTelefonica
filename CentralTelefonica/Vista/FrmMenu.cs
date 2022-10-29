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
    public partial class FrmMenu : Form
    {
        Centralita centralita;
        FrmLlamador frmLlamador;
        public FrmMenu()
        {
            InitializeComponent();
            centralita = new Centralita("Gonza ContactCenter");
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            frmLlamador = new FrmLlamador();
            frmLlamador.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
             centralita= frmLlamador.Centralita;
            FrmInformacion frmInformacion = new FrmInformacion($"Recaudacion total {centralita.GananciaTotal}");
            frmInformacion.Show();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            centralita = frmLlamador.Centralita;
            FrmInformacion frmInformacion = new FrmInformacion($"Recaudacion llamadas locales {centralita.GananciaPorProvincial}");
            frmInformacion.Show();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            centralita = frmLlamador.Centralita;
            FrmInformacion frmInformacion = new FrmInformacion($"Recaudacion llamadas provinciales {centralita.GananciaPorLocal}");
            frmInformacion.Show();
        }
    }
}
