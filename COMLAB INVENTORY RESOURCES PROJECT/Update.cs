using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace COMLAB_INVENTORY_RESOURCES_PROJECT
{
    public partial class Update : Form
    {

        string conn = "Data Source=localhost;Initial Catalog=IT_RES;User ID=sa;Password=12345678";
        int number, no; 
        string thing, type, day;

        private void Update_Load(object sender, EventArgs e)
        {
            textBox1.Text = number.ToString();
            rjTextBox3.Texts = thing;
            rjTextBox4.Texts = no.ToString();
           // rjDatePicker1.Text = day;
            rjComboBox2.Texts = type;
          
         
        }

        public Update(string item, int quantity,string category,int id, string date)
        {
            InitializeComponent();

            number = id;
            no = quantity;
            thing = item;
            type = category;
             //  day = date;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            thing = rjTextBox3.Texts;
            no = Convert.ToInt32(rjTextBox4.Texts);
            //day = rjDatePicker1.Text;
            number = Convert.ToInt32(textBox1.Text);
            type = rjComboBox2.Texts;

            DateTime day = DateTime.Now;
          

            SqlConnection con = new SqlConnection(conn);
            con.Open();

            try
            {
                string query = "UPDATE ITEMS SET ITEM=@ITEM, CATEGORY=@CATEGORY, QUANTITY=@QUANTITY, DATE=@DATE WHERE ID =@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", number);
                cmd.Parameters.AddWithValue("@ITEM", thing);
                cmd.Parameters.AddWithValue("@QUANTITY", no);
                cmd.Parameters.AddWithValue("@DATE", rjDatePicker1.Value);
                cmd.Parameters.AddWithValue("@CATEGORY", type);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Updated Succesfully");
                    this.Close();
                }


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
              
            }

            GetItems();
      

        }

        private void GetItems()
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=IT_RES;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.ITEMS", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

          




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
