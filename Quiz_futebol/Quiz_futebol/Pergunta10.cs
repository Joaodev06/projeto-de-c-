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
    public partial class Pergunta10 : Form
    {
      
        public Pergunta10()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        
            

        private void Button1_Click_1(object sender, EventArgs e)
        {
                if (radioButton1.Checked)
                {

                    int PontuacaoFinal = ScoreManager.Score;
                    ScoreManager.Score += 10;

                }
                else
                {
                }
                Form r10 = new Resposta();
                r10.Show();
                this.Hide();
            }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

        
    }

