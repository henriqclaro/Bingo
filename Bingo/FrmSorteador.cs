﻿using System;
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
    public partial class FrmSorteador : Form
    {
        Form anterior;
        int qtd;

        FrmCartela[] cartelas;

        bool[] sorteados;
        public FrmSorteador(Form anterior, int qtd)
        {
            InitializeComponent();
            this.anterior = anterior;
            this.qtd = qtd;

            sorteados = new bool[76];
            for (int i = 0; i < sorteados.Length; i++)
            {
                sorteados[i] = false;
            }

            cartelas = new FrmCartela[qtd];
            for (int i = 0; i < qtd; i++)
            {
                cartelas[i] = new FrmCartela(this, i);
                cartelas[i].Show();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            int num;
            Random r = new Random();

            do
            {
                num = r.Next(1, 76);
            } while (sorteados[num]);

            sorteados[num] = true;

            foreach (FrmCartela cartela in cartelas)
            {
                cartela.ReceberNumero(num);
            }

            lblNumero.Text = num.ToString();
        }

        public void NotificarVitoria(FrmCartela cartela)
        {
            foreach(FrmCartela c in cartelas)
            {
                if (c != cartela)
                {
                    c.Close();
                }
                btnProximo.Enabled = false;
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            FrmHistorico f = new FrmHistorico(sorteados);
            f.ShowDialog();
        }

        private void FrmSorteador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja encerrar este jogo?", "Bingo", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                foreach (FrmCartela cartela in cartelas)
                {
                    cartela.Close();
                }
                anterior.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
