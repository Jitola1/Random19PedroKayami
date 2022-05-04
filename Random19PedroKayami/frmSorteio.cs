using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random19PedroKayami
{
    public partial class frmSorteio : Form
    {
        private Random Random = new Random();
        public frmSorteio()
        {
            InitializeComponent();
        }

        private void btnCorform_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int valor1=0,valor2=0;
            valor1 = Random.Next(1,101);
            valor2 = Random.Next(1,101);
            lblValor1.Text = valor1.ToString();
            lblValor2.Text = valor2.ToString();
        }

        private void btnCena_Click(object sender, EventArgs e)
        {
            int numMega;
            numMega = Random.Next(1, 101);
            string cartao = "";
            for(int i=1; i<=6; i++)
            {
                numMega = Random.Next(1, 61);
                cartao += numMega.ToString("00-");
                lblMega.Text = cartao;
            }
        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picFotoJ1.Load(openFileDialog1.FileName);
            }
        }
    }
}
