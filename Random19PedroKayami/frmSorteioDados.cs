using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random19PedroKayami
{
    public partial class frmSorteioDados : Form
    {
        private Random sorteio = new Random();
        public frmSorteioDados()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {

        }
        private int JogarDados(PictureBox picDadojog1, PictureBox piDadojog2)
        {
            int dado1 = sorteio.Next (1, 7);
            int dado2 = sorteio.Next(1, 7);
            int ganhador = 0;
            string caminho1 = Directory.GetCurrentDirectory() +
                                               "\\imagem\\dado" + dado1 + ".jpg";
            picDadojog1.Image = Image.FromFile(caminho1);
            string caminho2 = Directory.GetCurrentDirectory() +
                                               "\\imagem\\dado" + dado2 + ".jpg";
            picDadojog2.Image = Image.FromFile(caminho2);
            if(dado1 > dado2)
            {
                ganhador = 1;
            }
            else if(dado2 > dado1)
            {
                ganhador = 2;
            }
            else
            {
                ganhador = 0;
            }
            return;
        }
    }
}
