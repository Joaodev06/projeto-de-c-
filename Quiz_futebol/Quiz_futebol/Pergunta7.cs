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
    public partial class Pergunta7 : Form
    {
      
        public Pergunta7()
        {
            InitializeComponent();
        }

        private void Pergunta7_Load(object sender, EventArgs e)
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
            Form p8 = new Pergunta8();
            p8.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

