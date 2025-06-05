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
    public partial class FrmHistorico : Form
    {
        public FrmHistorico(bool[] historico)
        {
            InitializeComponent();

            for (int i = 1;  i < historico.Length; i++)
            {
                string saiu = historico[i] ? "X" : " ";
                lbxHistorico.Items.Add($"{i}\t: [{saiu}]");
            }
        }
    }
}