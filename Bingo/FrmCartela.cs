using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class FrmCartela : Form
    {
        FrmSorteador sorteador;
        int id;

        int[][] numeros;
        Label[][] posicoes;

        int[][]intervalos;

        public FrmCartela(FrmSorteador sorteador, int id)
        {
            InitializeComponent();
            this.sorteador = sorteador;
            this.id = id;

            numeros = new int[5][]
            {
                new int[5],
                new int[5],
                new int[5],
                new int[5],
                new int[5]
            };
            posicoes = new Label[5][]
            {
                new Label[5]{ lbl1_1, lbl1_2, lbl1_3, lbl1_4, lbl1_5 },
                new Label[5]{ lbl2_1, lbl2_2, lbl2_3, lbl2_4, lbl2_5 },
                new Label[5]{ lbl3_1, lbl3_2, lbl3_3, lbl3_4, lbl3_5 },
                new Label[5]{ lbl4_1, lbl4_2, lbl4_3, lbl4_4, lbl4_5 },
                new Label[5]{ lbl5_1, lbl5_2, lbl5_3, lbl5_4, lbl5_5 },
            };

            intervalos = new int[5][]
            {
                new int[]{ 1, 15 },  // B
                new int[]{ 16, 30 }, // I
                new int[]{ 31, 45 }, // N
                new int[]{ 46, 60 }, // G
                new int[]{ 61, 75 }  // O
            };

            CriarCartela();
        }

        void CriarCartela()
        {
            for(int i = 0; i < 5; i++)
            {
                Random r = new Random();
                for(int j = 0; j < 5; j++)
                {
                    if (i == j && i == 2) continue;

                    int num = r.Next(intervalos[i][0], intervalos[i][1] + 1);
                    numeros[i][j] = num;
                    posicoes[i][j].Text = num.ToString();
                }
            }
        }

        public void ReceberNumero(int numero)
        {
            int i;
            for(i = 0; i < 5 && !(numero >= intervalos[i][0] && numero <= intervalos[i][1]); i++) ;
            for(int j = 0; j < 5; j++)
            {
                if (numeros[i][j] == numero)
                {
                    posicoes[i][j].BackColor = Color.Black;
                    posicoes[i][j].ForeColor = Color.White;
                    
                }
            }
        }
    }
}
