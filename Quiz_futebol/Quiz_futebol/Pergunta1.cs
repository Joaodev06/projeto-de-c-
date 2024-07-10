using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_futebol
{
    public partial class Pergunta1 : Form
    {
        public static class ScoreManager
        {
            public static int Score { get; set; }
        }

        public Pergunta1()
        {
        
            InitializeComponent();
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           

            if (radioButton1.Checked )
            {

                int PontuacaoFinal = ScoreManager.Score;
                ScoreManager.Score += 10;
            
            }
            else
            {


            }
            Form r10 = new Pergunta2();
            r10.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
