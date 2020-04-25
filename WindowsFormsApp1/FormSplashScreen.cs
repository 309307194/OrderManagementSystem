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
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            panelProgressBar.Width += 5;
            if(panelProgressBar.Width > 700)
            {
                timerProgressBar.Stop();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
