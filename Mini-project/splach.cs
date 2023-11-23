using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_project
{
    public partial class splach : Form
    {
        public splach()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Width += 3;
            
            if(progressBar.Width > 594)
            {
                timer1.Stop();
                dashboard dboard = new dashboard();
                dboard.Show();
                this.Hide();
            }
        }

        private void splach_Load(object sender, EventArgs e)
        {

        }
    }
}
