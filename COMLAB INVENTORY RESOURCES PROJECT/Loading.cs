using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMLAB_INVENTORY_RESOURCES_PROJECT
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 15;

            if (panel2.Width >= 865) 
            {
                timer1.Stop();

                Login lg = new Login();
                lg.Show();
                this.Hide();
            }



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
