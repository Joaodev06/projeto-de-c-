using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Quiz_futebol.Pergunta1;
namespace Quiz_futebol
{
    public partial class Pergunta3 : Form
    {
      
        public Pergunta3()
        {
            InitializeComponent();
        }

        private void Pergunta3_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                int PontuacaoFinal = ScoreManager.Score;
                ScoreManager.Score += 10;

            }
            else
            {
            }
            Form p4 = new Pergunta4();
            p4.Show();
            this.Hide();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

