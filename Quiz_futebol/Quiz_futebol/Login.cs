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
    public partial class Login : Form
    {
        string usuario_cd,senha_cd, new_cad;
        public Login(string u, string s, string n)
        {
          InitializeComponent();
           usuario_cd = u;
            senha_cd = s;
            new_cad = n;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form cadastro = new Cadastro(new_cad);
            cadastro.Show();
            this.Hide();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string usuario = textBox1.Text;
            string senha= textBox2.Text;
            if (usuario != usuario_cd || senha != senha_cd || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Dados incorretos", "Atenção", MessageBoxButtons.OK);
            }
            else
            {
                Form saudacao = new Saudacao(usuario);
                saudacao.Show();
                this.Hide();
            }

           
        }
    }
}
