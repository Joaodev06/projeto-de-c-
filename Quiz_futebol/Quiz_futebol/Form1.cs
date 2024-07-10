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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer2.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            



            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                System.Threading.Thread.Sleep(10);
            }
            if (progressBar1.Value == 100)
            {
                Form loginn = new Login("", "", "");
                loginn.Show();
                this.Hide();
                timer2.Stop();
            }
            
        

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
