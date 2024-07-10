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
    public partial class Saudacao : Form
    {
        string usuario;
        public Saudacao(string u)
        {
            usuario = u;
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Saudacao_Load(object sender, EventArgs e)
        {
            label2.Text = usuario;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form p1 = new Pergunta1();
            p1.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            label1.Text= "Olá, amantes do futebol! Sejam muito bem - vindos ao nosso quiz especial, organizado por Luiz Henrique Alcazar de Souza e João Pedro Scaramal. Estamos empolgados em testar seus conhecimentos sobre o esporte mais apaixonante do mundo! Preparem - se para desafiar suas habilidades e se divertir enquanto exploramos curiosidades, histórias e grandes momentos do futebol.Que comecem os jogos e boa sorte a todos!Abraços,Luiz Henrique Alcazar de Souza e João Pedro Scaramal";
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
