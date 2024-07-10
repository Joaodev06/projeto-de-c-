using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AULA5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void IOS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            if(IOS.Checked == true)
            {
                PIC1.Image = Properties.Resources.IOS;
            }
            else if (AND.Checked == true)
            {
                PIC1.Image = Properties.Resources.AND;
            }
            else if (LIN.Checked == true)
            {
                PIC1.Image = Properties.Resources.LIN;
            }
            else if  (WIND.Checked == true)
            {
                PIC1.Image = Properties.Resources.WIND;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WIND.Checked = false;
            IOS.Checked = false;
            AND.Checked = false;
            LIN.Checked = false;
            PIC1.Image = null;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PIC1_Click(object sender, EventArgs e)
        {



        }
    }
}
