using COMLAB_INVENTORY_RESOURCES_PROJECT.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics.Eventing.Reader;
using RJCodeAdvance.RJControls;

namespace COMLAB_INVENTORY_RESOURCES_PROJECT
{
    public partial class Dashboard : Form
    {

        static String conString = "Data Source=localhost;Initial Catalog=IT_RES;User ID=sa;Password=12345678";
        SqlConnection con = new SqlConnection(conString);
        DataSet ds = new DataSet();


        public Dashboard()

        {
            InitializeComponent();

         

 
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=IT_RES;User ID=sa;Password=12345678");
            

            addform.Hide();
            addform1.Hide();
            addform2.Hide();
            variance.Hide();
            variance2.Hide();
            variance3.Hide();

            rjCircularPictureBox2.Hide();

            GetItems();
            GetItems3();

            panel6.BackColor = Color.White;
            panel8.BackColor = Color.White;
            panel9.BackColor = Color.White;
        

        }

        string conn = "Data Source=localhost;Initial Catalog=IT_RES;User ID=sa;Password=12345678";


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void FillChart()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=IT_RES;User ID=sa;Password=12345678");
            DataTable dt = new DataTable();
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT ITEM, QUANTITY,DATE FROM dbo.ITEMS", con);
            da.Fill(dt);
            chart1.DataSource = dt;
            con.Close();

       

            chart1.Series["QUANTITY"].XValueMember = "DATE";
            chart1.Series["QUANTITY"].YValueMembers = "QUANTITY";
      


        }

        void FillChart2()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=IT_RES;User ID=sa;Password=12345678");
            DataTable dt = new DataTable();
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT ITEM, QUANTITY FROM dbo.ITEMS", con);
            da.Fill(dt);
            chart2.DataSource = dt;
            con.Close();



            chart2.Series["QUANTITY"].XValueMember = "ITEM";
            chart2.Series["QUANTITY"].YValueMembers = "QUANTITY";



        }



        private void rjButton6_Click(object sender, EventArgs e)
        {
            abbutton.BackColor = Color.WhiteSmoke;
            abbutton.ForeColor = Color.FromArgb(5, 123, 152);
            ibutton.BackColor = Color.Transparent;
            ibutton.ForeColor = Color.White;
            dbutton.BackColor = Color.Transparent;
            dbutton.ForeColor = Color.White;
            abutton.BackColor = Color.Transparent;
            abutton.ForeColor = Color.White;
            sbutton.BackColor = Color.Transparent;
            sbutton.ForeColor = Color.White;

            aboutp.Show();
            aboutp.BringToFront();
            dashboardp.Hide();
            hmp.Hide();
            archivep.Hide();


            abbutton.Image = Resources.informationb;
            dbutton.Image = Resources.dashboardb;
            ibutton.Image = Resources.itemsbb;
            abutton.Image = Resources.archivebb;
            sbutton.Image = Resources.signoutbb;


            rjComboBox1.Texts = ("");

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            abutton.BackColor = Color.WhiteSmoke;
            abutton.ForeColor = Color.FromArgb(5, 123, 152);
            ibutton.BackColor = Color.Transparent;
            ibutton.ForeColor = Color.White;
            dbutton.BackColor = Color.Transparent;
            dbutton.ForeColor = Color.White;
            abbutton.BackColor = Color.Transparent;
            abbutton.ForeColor = Color.White;
            sbutton.BackColor = Color.Transparent;
            sbutton.ForeColor = Color.White;

            archivep.Show();
            archivep.BringToFront();
            dashboardp.Hide();
            hmp.Hide();
            aboutp.Hide();


            abutton.Image = Resources.archiveb;
            dbutton.Image = Resources.dashboardb;
            ibutton.Image = Resources.itemsbb;
            abbutton.Image = Resources.informationbb;
            sbutton.Image = Resources.signoutbb;

            rjComboBox1.Texts = ("");
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=IT_RES;User ID=sa;Password=12345678");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM (QUANTITY) FROM dbo.ITEMS", conn);
            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM dbo.ITEMS", conn);

            var count1 = cmd.ExecuteScalar();
            var count2 = cmd2.ExecuteScalar();

            label23.Text = count1.ToString();
            label25.Text = count2.ToString();

            int rowCount = dataGridView2.Rows.Count;

            // Convert the count to a string
            string rowCountString = rowCount.ToString();

            // Set the string to the Text property of the Label
            label28.Text = rowCountString;


            timer1.Start();
            FillChart();
            FillChart2();


        }

        private void ibutton_Click(object sender, EventArgs e)
        {
            ibutton.BackColor = Color.WhiteSmoke;
            ibutton.ForeColor = Color.FromArgb(5, 123, 152);
            dbutton.BackColor = Color.Transparent;
            dbutton.ForeColor = Color.White;
            abutton.BackColor = Color.Transparent;
            abutton.ForeColor = Color.White;
            abbutton.BackColor = Color.Transparent;
            abbutton.ForeColor = Color.White;
            sbutton.BackColor = Color.Transparent;
            sbutton.ForeColor = Color.White;


            hmp.Show();
            hmp.BringToFront();
            dashboardp.Hide();
            archivep.Hide();
            aboutp.Hide();


            ibutton.Image = Resources.itemsb;
            dbutton.Image = Resources.dashboardb;
            abutton.Image = Resources.archivebb;
            abbutton.Image = Resources.informationbb;
            sbutton.Image = Resources.signoutbb;

            rjComboBox3.Texts = ("");


        }

        private void dbutton_Click(object sender, EventArgs e)
        {

            dbutton.BackColor = Color.WhiteSmoke;
            dbutton.ForeColor = Color.FromArgb(5, 123, 152);
            ibutton.BackColor = Color.Transparent;
            ibutton.ForeColor = Color.White;
            abutton.BackColor = Color.Transparent;
            abutton.ForeColor = Color.White;
            abbutton.BackColor = Color.Transparent;
            abbutton.ForeColor = Color.White;
            sbutton.BackColor = Color.Transparent;
            sbutton.ForeColor = Color.White;

            dashboardp.Show();
            dashboardp.BringToFront();
            hmp.Hide();
            archivep.Hide();
            aboutp.Hide();



            dbutton.Image = Resources.dashboardbb;
            ibutton.Image = Resources.itemsbb;
            abutton.Image = Resources.archivebb;
            abbutton.Image = Resources.informationbb;
            sbutton.Image = Resources.signoutbb;


            rjComboBox1.Texts = ("");
            rjComboBox3.Texts = ("");


        }

        private void sbutton_Click(object sender, EventArgs e)
        {



            sbutton.BackColor = Color.WhiteSmoke;
            sbutton.ForeColor = Color.FromArgb(5, 123, 152);
            ibutton.BackColor = Color.Transparent;
            ibutton.ForeColor = Color.White;
            abutton.BackColor = Color.Transparent;
            abutton.ForeColor = Color.White;
            abbutton.BackColor = Color.Transparent;
            abbutton.ForeColor = Color.White;
            dbutton.BackColor = Color.Transparent;
            dbutton.ForeColor = Color.White;

            sbutton.Image = Resources.signoutb;
            ibutton.Image = Resources.itemsbb;
            abutton.Image = Resources.archivebb;
            abbutton.Image = Resources.informationbb;
            dbutton.Image = Resources.dashboardb;

                
            signout so = new signout();
            so.ShowDialog();

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void itemsp_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();

            GetItems();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label15.Text = DateTime.Now.ToLongDateString();
            timed.Text = DateTime.Now.ToShortTimeString();
            dated.Text = DateTime.Now.ToLongDateString();
            date.Text = DateTime.Now.ToLongDateString();
            label5.Text = DateTime.Now.ToLongDateString();
            label39.Text = DateTime.Now.ToLongDateString();
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            rjCircularPictureBox2.Show();
            addform.Show();
           
        }

        private void signoutp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutp_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iT_RESDataSet4.SPORTS' table. You can move, or remove it, as needed.
            this.sPORTSTableAdapter.Fill(this.iT_RESDataSet4.SPORTS);
            // TODO: This line of code loads data into the 'iT_RESDataSet3.SCIENCE' table. You can move, or remove it, as needed.
            this.sCIENCETableAdapter.Fill(this.iT_RESDataSet3.SCIENCE);


            // TODO: This line of code loads data into the 'iT_RESDataSet.ITEMS' table. You can move, or remove it, as needed.
            this.iTEMSTableAdapter.Fill(this.iT_RESDataSet.ITEMS);

            Sort("ID");
            userControl12.Hide();
     


        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            rjCircularPictureBox2.Hide();
            addform.Hide();
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            rjCircularPictureBox2.Hide();
            addform.Hide();
           
        }

        private void rjButton6_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=IT_RES;User ID=sa;Password=12345678");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.ITEMS ([ITEM],[CATEGORY],[QUANTITY],[STATUS],[DATE]) Values (@ITEM,@CATEGORY,@QUANTITY,@STATUS,@DATE)", con);
            cmd.Parameters.AddWithValue("@ITEM", rjTextBox4.Texts);
            cmd.Parameters.AddWithValue("@CATEGORY", rjComboBox2.Texts);
            cmd.Parameters.AddWithValue("@QUANTITY", rjTextBox2.Texts);
            cmd.Parameters.AddWithValue("@STATUS", "AVAILABLE");
            cmd.Parameters.AddWithValue("@DATE", DateTime.Now);


            cmd.ExecuteNonQuery();
            con.Close();

            rjTextBox4.Texts = ("");
            rjComboBox2.Texts = ("");
            rjTextBox2.Texts = ("");

            MessageBox.Show("Added Successfully");
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

            dataGridView1.DataSource = dt;



             
        }  

        private void GetItems2()
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=IT_RES;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.ARCHIVE", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView2.DataSource = dt;




        }

        private void GetItems3()
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=IT_RES;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.SCIENCE", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView4.DataSource = dt;




        }

        private void GetItems4()
        {

            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=IT_RES;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.SPORTS", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView5.DataSource = dt;




        }

        private void rjButton4_Click_1(object sender, EventArgs e)
        {

        }

        private void rjComboBox2_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void rjButton7_Click(object sender, EventArgs e)
        {




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            string col = dataGridView1.Columns[e.ColumnIndex].HeaderText;
           

            if (col == "  ")
                    

            {

                dataGridView2.Rows.Add(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),"NOT AVAILABLE", "DAMAGED", dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
             

            }

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "  ")
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                var result = MessageBox.Show(
                 string.Format("Do you want to delete this item?", row.Cells["iDDataGridViewTextBoxColumn"].Value),
                "Confirmation",
                 MessageBoxButtons.YesNo);

               
                if (result == DialogResult.Yes)
                {
                    variance.Show();

                    using (SqlConnection con1 = new SqlConnection(conn))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM ITEMS WHERE ID= @ID", con1))
                        {
                            cmd.Parameters.AddWithValue("@ID", row.Cells["iDDataGridViewTextBoxColumn"].Value);
                            con1.Open();
                            cmd.ExecuteNonQuery();
                            con1.Close();
                        }
                    }


                 


                     






                }

                {
                   

                   
                    GetItems();
                }



            }


            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == " ")
            {

                int quantity, id;
                string item, category, date;

                id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["iDDataGridViewTextBoxColumn"].Value);
                quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["qUANTITYDataGridViewTextBoxColumn"].Value);
                item = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["iTEMDataGridViewTextBoxColumn"].Value);
                category = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["cATEGORYDataGridViewTextBoxColumn"].Value);
                date = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["dATEDataGridViewTextBoxColumn"].Value);


                Update up = new Update (item, quantity, category,id,date);
                up.ShowDialog();

                


                GetItems();
            }



        }

        public void searchData(string valueToSearch)
        {

            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=IT_RES;User ID=sa;Password=12345678");
            SqlCommand command;
            SqlDataAdapter adapter;
            DataTable dt;



            string searchQuery = "SELECT * FROM dbo.ITEMS WHERE CONCAT (ID,ITEM,CATEGORY) LIKE '%" + valueToSearch + "%'";
            command = new SqlCommand(@searchQuery, con);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

    


        private void rjButton7_Click_1(object sender, EventArgs e)
        {
            

            variance.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            
            

                         
        }

        private void date_Click_1(object sender, EventArgs e)
        {

        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {
            searchData("");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string valueToSearch = rjTextBox3.Texts.ToString();
            searchData(valueToSearch);
           
        }

        private void rjButton13_Click(object sender, EventArgs e)
        {

        }

       

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Sort(rjComboBox1.SelectedItem.ToString());
        }

        private void Sort(string value)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd;
            DataView dv;

            string sql = "SELECT * FROM dbo.ITEMS";
            cmd = new SqlCommand(sql, con);
            adapter.SelectCommand = cmd;

            ds.Clear();
            adapter.Fill(ds);
            dv = new DataView(ds.Tables[0]);
            dv.Sort = value;

            dataGridView1.DataSource = dv;
       

        }

        private void Sort2(string columnName)
        {
           
        }

        private void rjComboBox3_OnSelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void rjButton10_Click(object sender, EventArgs e)
        {
            userControl12.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void archivep_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton17_Click(object sender, EventArgs e)
        {
          
        }

        private void rjButton16_Click(object sender, EventArgs e)
        {

        }

        private void rjButton18_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
         
        }

        private void panel6_MouseMove_1(object sender, MouseEventArgs e)
        {
         
            panel6.BackColor = Color.FromArgb(236, 246, 240);
            hat.BackColor = Color.FromArgb(236, 246, 240);

        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.White;
            hat.BackColor = Color.White;
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            panel8.BackColor = Color.FromArgb(251, 253, 239);
            scope.BackColor = Color.FromArgb(251, 253, 239);
        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.White;
            scope.BackColor = Color.White;
        }

        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            panel9.BackColor = Color.FromArgb(253, 236, 236);
            ball.BackColor = Color.FromArgb(253, 236, 236);
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.White;
            ball.BackColor = Color.White;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            hat.Top -= 3;
            ball.Top -= 3;
         

            if (hat.Top <= 229)
            {
                timer2.Stop();
                timer3.Start();
            }

            if (ball.Top <= 229)
            {
                timer2.Stop();
                timer3.Start();
            }

        
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            hat.Top += 3;
            ball.Top += 3;

            if (hat.Top >= 282)
            {

                timer2.Start();
                timer3.Stop();

            }

            if (ball.Top >= 282)
            {

                timer2.Start();
                timer3.Stop();

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            scope.Top -= 3;

            if (scope.Top <= 249)
            {
                timer5.Start();
                timer4.Stop();

            }

        }

        private void timer5_Tick(object sender, EventArgs e)
        {

            scope.Top += 3;

            if (scope.Top >= 269)
            {

                timer4.Start();
                timer5.Stop();

            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

                      

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
    
            panel1.Show();
            panel1.BringToFront();
              

        }

        private void hat_Click(object sender, EventArgs e)
        {
            itemsp.Show();
            itemsp.BringToFront();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
          
            
        }

        private void hat_MouseMove(object sender, MouseEventArgs e)
        {
            hat.BackColor = Color.FromArgb(236, 246, 240);
            panel6.BackColor = Color.FromArgb(236, 246, 240);
            pictureBox15.BackColor = Color.FromArgb(236, 246, 240);
        }

        private void hat_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.White;
            hat.BackColor = Color.White;
            pictureBox15.BackColor = Color.White;
        }

        private void scope_MouseMove(object sender, MouseEventArgs e)
        {
              panel8.BackColor = Color.FromArgb(251, 253, 239);
            scope.BackColor = Color.FromArgb(251, 253, 239);
            pictureBox16.BackColor = Color.FromArgb(251, 253, 239);
        }

        private void scope_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.White;
            scope.BackColor = Color.White;
            pictureBox16.BackColor = Color.White;
        }

        private void scope_Click(object sender, EventArgs e)
        {
            sciencep.Show();
            sciencep.BringToFront();
        }

        private void ball_MouseMove(object sender, MouseEventArgs e)
        {
            panel9.BackColor = Color.FromArgb(253, 236, 236);
            ball.BackColor = Color.FromArgb(253, 236, 236);
            pictureBox17.BackColor = Color.FromArgb(253, 236, 236);
        }

        private void ball_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.White;
            ball.BackColor = Color.White;
            pictureBox17.BackColor = Color.White;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
           pictureBox6.BackgroundImage = Properties.Resources.dashh;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = Properties.Resources.d;
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.BackgroundImage = Properties.Resources.itemsss;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackgroundImage = Properties.Resources.i;
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox8.BackgroundImage = Properties.Resources.archh;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.BackgroundImage = Properties.Resources.a;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Show();
            dashboardp.Show();
            dashboardp.BringToFront();

            dbutton.BackColor = Color.WhiteSmoke;
            dbutton.ForeColor = Color.FromArgb(5, 123, 152);
            ibutton.BackColor = Color.Transparent;
            ibutton.ForeColor = Color.White;
            abutton.BackColor = Color.Transparent;
            abutton.ForeColor = Color.White;

            dbutton.Image = Resources.dashboardbb;
            ibutton.Image = Resources.itemsbb;
            abutton.Image = Resources.archivebb;

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Show();
            archivep.Show();
            archivep.BringToFront();

            abutton.BackColor = Color.WhiteSmoke;
            abutton.ForeColor = Color.FromArgb(5, 123, 152);
            ibutton.BackColor = Color.Transparent;
            ibutton.ForeColor = Color.White;
            dbutton.BackColor = Color.Transparent;
            dbutton.ForeColor = Color.White;

            abutton.Image = Resources.archiveb;
            dbutton.Image = Resources.dashboardb;
            ibutton.Image = Resources.itemsbb;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Show();
            archivep.Show();
            archivep.BringToFront();

            abutton.BackColor = Color.WhiteSmoke;
            abutton.ForeColor = Color.FromArgb(5, 123, 152);
            ibutton.BackColor = Color.Transparent;
            ibutton.ForeColor = Color.White;
            dbutton.BackColor = Color.Transparent;
            dbutton.ForeColor = Color.White;

            abutton.Image = Resources.archiveb;
            dbutton.Image = Resources.dashboardb;
            ibutton.Image = Resources.itemsbb;
        }

        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox11.BackgroundImage = Properties.Resources.dd1;
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)   
        {
            pictureBox11.BackgroundImage = Properties.Resources.d2;
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox10.BackgroundImage = Properties.Resources.ii1;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.BackgroundImage = Properties.Resources.i1;
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox9.BackgroundImage = Properties.Resources.aa1;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.BackgroundImage = Properties.Resources.a1;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Show();
            dashboardp.Show();
            dashboardp.BringToFront();

            dbutton.BackColor = Color.WhiteSmoke;
            dbutton.ForeColor = Color.FromArgb(5, 123, 152);
            ibutton.BackColor = Color.Transparent;
            ibutton.ForeColor = Color.White;
            abutton.BackColor = Color.Transparent;
            abutton.ForeColor = Color.White;

            dbutton.Image = Resources.dashboardbb;
            ibutton.Image = Resources.itemsbb;
            abutton.Image = Resources.archivebb;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
        }

        private void ball_Click(object sender, EventArgs e)
        {
            sportsp.Show();
            sportsp.BringToFront();
        }

        private void pictureBox14_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox14.BackgroundImage = Properties.Resources.d5;
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.BackgroundImage = Properties.Resources.d4;
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox13.BackgroundImage = Properties.Resources.i4;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.BackgroundImage = Properties.Resources.i3;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Show();
            archivep.Show();
            archivep.BringToFront();

            abutton.BackColor = Color.WhiteSmoke;
            abutton.ForeColor = Color.FromArgb(5, 123, 152);
            ibutton.BackColor = Color.Transparent;
            ibutton.ForeColor = Color.White;
            dbutton.BackColor = Color.Transparent;
            dbutton.ForeColor = Color.White;

            abutton.Image = Resources.archiveb;
            dbutton.Image = Resources.dashboardb;
            ibutton.Image = Resources.itemsbb;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.BackgroundImage = Properties.Resources.a3;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.BringToFront();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Show();
            dashboardp.Show();
            dashboardp.BringToFront();

            dbutton.BackColor = Color.WhiteSmoke;
            dbutton.ForeColor = Color.FromArgb(5, 123, 152);
            ibutton.BackColor = Color.Transparent;
            ibutton.ForeColor = Color.White;
            abutton.BackColor = Color.Transparent;
            abutton.ForeColor = Color.White;

            dbutton.Image = Resources.dashboardbb;
            ibutton.Image = Resources.itemsbb;
            abutton.Image = Resources.archivebb;
        }

        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox12.BackgroundImage = Properties.Resources.a4;
        }


        private void pictureBox15_Click_1(object sender, EventArgs e)
        {
            itemsp.Show();
            itemsp.BringToFront();
        }

        private void pictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox15.BackColor = Color.FromArgb(236, 246, 240);
            hat.BackColor = Color.FromArgb(236, 246, 240);
            panel6.BackColor = Color.FromArgb(236, 246, 240);
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.BackColor = Color.White;
            hat.BackColor = Color.White;
            panel6.BackColor = Color.White;
        }

        private void pictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            panel8.BackColor = Color.FromArgb(251, 253, 239);
            pictureBox16.BackColor = Color.FromArgb(251, 253, 239);
            scope.BackColor = Color.FromArgb(251, 253, 239);
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.BackColor = Color.White;
            panel8.BackColor = Color.White;
            scope.BackColor = Color.White;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            sciencep.Show();
            sciencep.BringToFront();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            sportsp.Show();
            sportsp.BringToFront();
        }

        private void pictureBox17_MouseMove(object sender, MouseEventArgs e)
        {
            panel9.BackColor = Color.FromArgb(253, 236, 236);
            ball.BackColor = Color.FromArgb(253, 236, 236);
            pictureBox17.BackColor = Color.FromArgb(253, 236, 236);
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.White;
            ball.BackColor = Color.White;
            pictureBox17.BackColor = Color.White;
        }

        private void rjButton20_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=IT_RES;User ID=sa;Password=12345678");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.SCIENCE ([ITEM],[CATEGORY],[QUANTITY],[STATUS],[DATE]) Values (@ITEM,@CATEGORY,@QUANTITY,@STATUS,@DATE)", con);
            cmd.Parameters.AddWithValue("@ITEM", rjTextBox8.Texts);
            cmd.Parameters.AddWithValue("@CATEGORY", rjComboBox5.Texts);
            cmd.Parameters.AddWithValue("@QUANTITY", rjTextBox7.Texts);
            cmd.Parameters.AddWithValue("@STATUS", "AVAILABLE");
            cmd.Parameters.AddWithValue("@DATE", DateTime.Now);


            cmd.ExecuteNonQuery();
            con.Close();

            rjTextBox8.Texts = ("");
            rjComboBox5.Texts = ("");
            rjTextBox7.Texts = ("");

            MessageBox.Show("Added Successfully");
            GetItems3();
        }

        private void rjButton18_Click_1(object sender, EventArgs e)
        {
            addform1.Show();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            addform1.Hide();
        }

        private void rjButton19_Click(object sender, EventArgs e)
        {
            addform1.Hide();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = dataGridView4.Columns[e.ColumnIndex].HeaderText;


            if (col == "  ")


            {

                dataGridView2.Rows.Add(dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView4.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView4.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridView4.Rows[e.RowIndex].Cells[3].Value.ToString(), "NOT AVAILABLE", "DAMAGED", dataGridView4.Rows[e.RowIndex].Cells[5].Value.ToString());


            }

            if (dataGridView4.Columns[e.ColumnIndex].HeaderText == "  ")
            {

                DataGridViewRow row = dataGridView4.Rows[e.RowIndex];
                var result = MessageBox.Show(
                 string.Format("Do you want to delete this item?", row.Cells["dataGridViewTextBoxColumn13"].Value),
                "Confirmation",
                 MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {
                    variance2.Show();

                    using (SqlConnection con1 = new SqlConnection(conn))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM SCIENCE WHERE ID= @ID", con1))
                        {
                            cmd.Parameters.AddWithValue("@ID", row.Cells["dataGridViewTextBoxColumn13"].Value);
                            con1.Open();
                            cmd.ExecuteNonQuery();
                            con1.Close();
                        }
                    }












                }

                {



                    GetItems3();
                }

              

            }

            if (dataGridView4.Columns[e.ColumnIndex].HeaderText == " ")
            {

                int quantity, id;
                string item, category, date;

                id = Convert.ToInt32(dataGridView4.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn13"].Value);
                quantity = Convert.ToInt32(dataGridView4.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn16"].Value);
                item = Convert.ToString(dataGridView4.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn14"].Value);
                category = Convert.ToString(dataGridView4.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn15"].Value);
                date = Convert.ToString(dataGridView4.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn18"].Value);


                UPDATE2 up2 = new UPDATE2(item, quantity, category, id, date);
                up2.ShowDialog();




                GetItems3();
            }
        }

        private void rjButton21_Click(object sender, EventArgs e)
        {
            variance2.Hide();

        }

        private void rjComboBox4_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Sort3(rjComboBox4.SelectedItem.ToString());
        }

        private void Sort3(string value)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd;
            DataView dv;

            string sql = "SELECT * FROM dbo.SCIENCE";
            cmd = new SqlCommand(sql, con);
            adapter.SelectCommand = cmd;

            ds.Clear();
            adapter.Fill(ds);
            dv = new DataView(ds.Tables[0]);
            dv.Sort = value;

            dataGridView4.DataSource = dv;


        }

        public void searchData2(string valueToSearch)
        {

            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=IT_RES;User ID=sa;Password=12345678");
            SqlCommand command;
            SqlDataAdapter adapter;
            DataTable dt;



            string searchQuery = "SELECT * FROM dbo.SCIENCE WHERE CONCAT (ID,ITEM,CATEGORY) LIKE '%" + valueToSearch + "%'";
            command = new SqlCommand(@searchQuery, con);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView4.DataSource = dt;

        }

        private void rjTextBox6__TextChanged(object sender, EventArgs e)
        {
            searchData2("");
        }

        private void rjTextBox6_Enter(object sender, EventArgs e)
        {
        
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            string valueToSearch = rjTextBox6.Texts.ToString();
            searchData2(valueToSearch);
        }

        private void rjButton22_Click(object sender, EventArgs e)
        {
            addform2.Show();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            addform2.Hide();
        }

        private void rjButton23_Click(object sender, EventArgs e)
        {
            addform2.Hide();
        }

        private void rjButton24_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=IT_RES;User ID=sa;Password=12345678");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO dbo.SPORTS ([ITEM],[CATEGORY],[QUANTITY],[STATUS],[DATE]) Values (@ITEM,@CATEGORY,@QUANTITY,@STATUS,@DATE)", con);
            cmd.Parameters.AddWithValue("@ITEM", rjTextBox11.Texts);
            cmd.Parameters.AddWithValue("@CATEGORY", rjComboBox7.Texts);
            cmd.Parameters.AddWithValue("@QUANTITY", rjTextBox10.Texts);
            cmd.Parameters.AddWithValue("@STATUS", "AVAILABLE");
            cmd.Parameters.AddWithValue("@DATE", DateTime.Now);


            cmd.ExecuteNonQuery();
            con.Close();

            rjTextBox11.Texts = ("");
            rjComboBox7.Texts = ("");
            rjTextBox10.Texts = ("");

            MessageBox.Show("Added Successfully");
            GetItems4();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string col = dataGridView5.Columns[e.ColumnIndex].HeaderText;


            if (col == "  ")


            {

                dataGridView2.Rows.Add(dataGridView5.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView5.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView5.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridView5.Rows[e.RowIndex].Cells[3].Value.ToString(), "NOT AVAILABLE", "DAMAGED", dataGridView5.Rows[e.RowIndex].Cells[5].Value.ToString());


            }

            if (dataGridView5.Columns[e.ColumnIndex].HeaderText == "  ")
            {

                DataGridViewRow row = dataGridView5.Rows[e.RowIndex];
                var result = MessageBox.Show(
                 string.Format("Do you want to delete this item?", row.Cells["dataGridViewTextBoxColumn25"].Value),
                "Confirmation",
                 MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {
                    variance3.Show();

                    using (SqlConnection con1 = new SqlConnection(conn))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM SPORTS WHERE ID= @ID", con1))
                        {
                            cmd.Parameters.AddWithValue("@ID", row.Cells["dataGridViewTextBoxColumn25"].Value);
                            con1.Open();
                            cmd.ExecuteNonQuery();
                            con1.Close();
                        }
                    }












                }

                {



                    GetItems4();
                }



            }

            if (dataGridView5.Columns[e.ColumnIndex].HeaderText == " ")
            {

                int quantity, id;
                string item, category, date;

                id = Convert.ToInt32(dataGridView5.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn25"].Value);
                quantity = Convert.ToInt32(dataGridView5.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn28"].Value);
                item = Convert.ToString(dataGridView5.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn26"].Value);
                category = Convert.ToString(dataGridView5.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn27"].Value);
                date = Convert.ToString(dataGridView5.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn30"].Value);


                Update3 up3 = new Update3(item, quantity, category, id, date);
                up3.ShowDialog();




                GetItems4();
            }
        }

        private void rjButton25_Click(object sender, EventArgs e)
        {
            variance3.Hide();
        }

        private void rjComboBox6_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            Sort4(rjComboBox6.SelectedItem.ToString());
        }

        private void Sort4(string value)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd;
            DataView dv;

            string sql = "SELECT * FROM dbo.SPORTS";
            cmd = new SqlCommand(sql, con);
            adapter.SelectCommand = cmd;

            ds.Clear();
            adapter.Fill(ds);
            dv = new DataView(ds.Tables[0]);
            dv.Sort = value;

            dataGridView5.DataSource = dv;


        }

        private void rjTextBox9__TextChanged(object sender, EventArgs e)
        {
            searchData3("");
        }

        public void searchData3(string valueToSearch)
        {

            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=IT_RES;User ID=sa;Password=12345678");
            SqlCommand command;
            SqlDataAdapter adapter;
            DataTable dt;



            string searchQuery = "SELECT * FROM dbo.SPORTS WHERE CONCAT (ID,ITEM,CATEGORY) LIKE '%" + valueToSearch + "%'";
            command = new SqlCommand(@searchQuery, con);
            adapter = new SqlDataAdapter(command);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView5.DataSource = dt;

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            string valueToSearch = rjTextBox9.Texts.ToString();
            searchData3(valueToSearch);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
