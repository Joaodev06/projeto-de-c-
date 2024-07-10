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
    
    public partial class Resposta : Form
    {
       
            public static int Score { get; private set; }
      
        public Resposta()
        {
            InitializeComponent();
        }

        private void Resposta_Load(object sender, EventArgs e)
        {
            int erradas;
            
            erradas = 100 - ScoreManager.Score;
  label1.Text =" Pontuação final:" + ScoreManager.Score.ToString() + "%";
            label2.Text = "Você errou:" + erradas + "%";

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            label1.Text = " Pontuação final:" + ScoreManager.Score.ToString() + "%";
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            int erradas;

            erradas = 100 - ScoreManager.Score;
            label2.Text = "Você errou:" + erradas + "%";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form p1 = new Pergunta1();
            p1.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
