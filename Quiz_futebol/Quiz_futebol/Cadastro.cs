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
    public partial class Cadastro : Form
    {
        string nome;
        public Cadastro(string n)
        {
            InitializeComponent();
            nome = n;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           if(SENHA.Text != CONSENHA.Text )
            {
                MessageBox.Show("Senha diferentes", "Atenção",MessageBoxButtons.OK);
            }
            
            
            
            else { string usuario_cd = USU.Text;
                string senha_cd = SENHA.Text;
                string confirm = CONSENHA.Text;
                Form login = new Login(usuario_cd , senha_cd,confirm);
                login.Show();
                this.Hide();
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
