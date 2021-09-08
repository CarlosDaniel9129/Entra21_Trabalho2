using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho2_Carlos_Daniel_Thiago_Formento.Control;
using Trabalho2_Carlos_Daniel_Thiago_Formento.Model;

namespace Trabalho2_Carlos_Daniel_Thiago_Formento
{
    public partial class Form1 : Form
    {
        string[][] matriz = new string[5][];
        int pontos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            pontos = 0;
            lbPontuacao.Text = "";
            PreencheDG();
            Controller2.palavras.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencheDG();
        }


        private void PreencheDG()
        {
            DGCacaLetra.Rows.Clear();

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new string[5];
            }
            int p = 0; //para percorrer o vetor de letras

            for (int l = 0; l < matriz.Length; l++)
            {
                for (int c = 0; c < matriz[l].Length; c++)
                {
                    if (c > 0 && c < 4 && l > 0 && l < 4) //para que a coluna 0 e 4 fiquem nulls e a linha 0 e 4 fiquem nulls
                    {
                        matriz[l][c] = Functions.GeraLista()[p];
                        p++;
                    }
                }
            }

            int j = 0;

            for (int i = 0; i < 8; i++)
            {
                string[] metade = new string[3];

                while (j < 3)
                {
                    metade[j] = Functions.GeraLista()[i];
                    j++;
                    i++;
                }

                DGCacaLetra.Rows.Add(metade);

                j = 0;
                i--;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string ponto = Controller2.Verifica(matriz, txtEntrada.Text.ToUpper());

            if (ponto == "POSSUI")
            {
                MessageBox.Show("Essa palavra já foi inserida");
            }
            else
            {
                pontos += Convert.ToInt32(ponto) / 2;
                lbPontuacao.Text = pontos.ToString();
                lbPontuacao.Visible = true;
                txtEntrada.Clear();
            }


        }
    }
}
