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
    public partial class signout : Form
    {
        public signout()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {

            Dashboard db = new Dashboard();
            db.Hide();
            Login lg = new Login();
            this.Hide();
     
            lg.ShowDialog();

           
          




        }

        private void signout_Load(object sender, EventArgs e)
        {

        }
    }
}
