using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissaoSecundaria
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
        static int ContarBuracos(String textoDigitado)
        {
            int buracos = 0;

            foreach (var item in textoDigitado)
            {

                if (item == 'a' || item == 'A')
                {
                    buracos++;
                }
                if (item == 'b')
                {
                    buracos++;
                }
                if (item == 'B')
                {
                    buracos += 2;
                }
                if (item == 'd' || item == 'D')
                {
                    buracos++;
                }
                if (item == 'e')
                {
                    buracos++;
                }
                if (item == 'g')
                {
                    buracos++;
                }
                if (item == 'o' || item == 'O')
                {
                    buracos++;
                }
                if (item == 'p' || item == 'P')
                {
                    buracos++;
                }
                if (item == 'q' || item == 'Q')
                {
                    buracos++;
                }
                if (item == 'R')
                {
                    buracos++;
                }
            }
            return buracos;
        }

        private void label3_Click(object sender, EventArgs e) // --
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var textoDigitado = tbTexto.Text;
            lbBuracos.Text = ContarBuracos(textoDigitado).ToString();
            lbLetras.Text = ContarLetras(textoDigitado).ToString();
            lbPalavras.Text = ContarPalavras(textoDigitado).ToString();
        }
        //

        public int ContarPalavras(String textoDigitado)
        {

            String[] palavras = textoDigitado.Split(' ');
            int totPalavras = palavras.Length;
            return totPalavras;

        }

        public int ContarLetras(String textoDigitado)
        {
            int textoLetras = textoDigitado.Replace(" ", string.Empty).Length;
            return textoLetras;
        }

        private void tbTexto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
