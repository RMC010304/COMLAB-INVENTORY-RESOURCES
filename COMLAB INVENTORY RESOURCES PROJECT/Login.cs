using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMLAB_INVENTORY_RESOURCES_PROJECT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
   
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void RegisterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();

            
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
           
            scanbutton.BackColor = Color.Transparent;
            registerbutton.BackColor = Color.White;
            scanbutton.ForeColor = Color.White;
            registerbutton.ForeColor = Color.FromArgb(5, 123, 152);

            ScanPanel.Hide();
            RegisterPanel.Show();

           

        }

        private void scanbutton_Click(object sender, EventArgs e)
        {

            registerbutton.BackColor = Color.Transparent;
            scanbutton.BackColor = Color.White;
            registerbutton.ForeColor = Color.White;
            scanbutton.ForeColor = Color.FromArgb(5, 123, 152);

            RegisterPanel.Hide();
            ScanPanel.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            card.Top -= 3;

            if (card.Top <= 261)
            {
                timer1.Stop();
                timer2.Start();
            }


        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
     
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            card.Top += 3;

            if (card.Top <= 285)
            {

                timer1.Start();
                timer2.Stop();

            }
        }

        private void card_Click(object sender, EventArgs e)
        {

        }

        private void ScanPanel_Paint(object sender, PaintEventArgs e)
        {


           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox2__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
