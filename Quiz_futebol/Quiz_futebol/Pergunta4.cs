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
    public partial class Pergunta4 : Form
    {
       
        public Pergunta4()
        {
            InitializeComponent();
        }

        private void Pergunta4_Load(object sender, EventArgs e)
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
            Form p5 = new Pergunta5();
            p5.Show();
            this.Hide();
        }

       

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

