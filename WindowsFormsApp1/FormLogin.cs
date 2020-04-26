using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity >= 0.025)
            {
                this.Opacity -= 0.025;  //递减窗体的不透明度
            }
            else
            {
                timer1.Stop();
                this.Close();
                Application.Exit();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
