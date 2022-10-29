using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmInformacion : Form
    {
        private string informacion;
        public FrmInformacion()
        {
            InitializeComponent();
        }

        public FrmInformacion(string informacion)
        {
            InitializeComponent();
            this.informacion = informacion;
        }


        private void FrmInformacion_Load(object sender, EventArgs e)
        {
            rtbInformacion.Text = $"{this.informacion}";
        }
    }
}
