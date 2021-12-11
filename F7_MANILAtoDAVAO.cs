using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lets_gooo
{
    public partial class F7_MANILAtoDAVAO : Form
    {


        public static string form2txt = "";
        public static string form21txt = "";
        public static string form22txt = "";
        public static string form23txt = "";
        public F7_MANILAtoDAVAO()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource = localhost; port= 3306; database = finals; username = root; password =;");
        OUTPUT output = new OUTPUT();

        public void dataView()
        {
            string selectQuery = "SELECT seat FROM seat_table";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public void execQ(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    //MessageBox.Show("query executed");
                    output.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("query failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            //cmd.Dispose();
        }

        private void F7_MANILAtoDAVAO_Load(object sender, EventArgs e)
        {
            dataView();
        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            //OUTPUT output = new OUTPUT();
            //string currentDate = DateTime.Now.ToString("yyyy-MM-dd")
            string insert = "INSERT into seat_table (price, nickname, seat, reservation_date, date_from, airline) VALUES ('" + "P1,500" + "','" + txtNickName.Text + "', '" + txtSeatNumber.Text + "', '" + dateTimePicker1.Text + "', '"+ DateTime.Now.ToString("yyyy-MM-dd") +"', '" + "CEBU PACIFIC" + "')";
            string insertONE = "INSERT into seat_table (price, nickname, seat, reservation_date, date_from, airline) VALUES ('" + "P2,500" + "','" + txtNickName.Text + "', '" + txtSeatNumber.Text + "', '" + dateTimePicker1.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + "CEBU PACIFIC" + "')";
            string insertTWO = "INSERT into seat_table (price, nickname, seat, reservation_date, date_from, airline) VALUES ('" + "P3,500" + "','" + txtNickName.Text + "', '" + txtSeatNumber.Text + "', '" + dateTimePicker1.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + "CEBU PACIFIC" + "')";

            string insert11 = "INSERT into seat_table (price, nickname, seat, reservation_date, date_from, airline) VALUES ('" + "P1,500" + "','" + txtNickName.Text + "','" + txtSeatNumber.Text + "', '" + dateTimePicker1.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + "AIR-ASIA" + "')";
            string insert12 = "INSERT into seat_table (price, nickname, seat, reservation_date, date_from, airline) VALUES ('" + "P2,500" + "','" + txtNickName.Text + "','" + txtSeatNumber.Text + "', '" + dateTimePicker1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + "AIR-ASIA" + "')";
            string insert13 = "INSERT into seat_table (price, nickname, seat, reservation_date, date_from, airline) VALUES ('" + "P3,500" + "','" + txtNickName.Text + "','" + txtSeatNumber.Text + "', '" + dateTimePicker1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + "AIR-ASIA" + "')";


            string insert21= "INSERT into seat_table (price, nickname, seat, reservation_date, date_from, airline) VALUES ('" + "P1,500" + "','" + txtNickName.Text + "','" + txtSeatNumber.Text + "', '" + dateTimePicker1.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + "PHILIPPINE AIRLINES" + "')";
            string insert22 = "INSERT into seat_table (price, nickname, seat, reservation_date, date_from, airline) VALUES ('" + "P2,500" + "','" + txtNickName.Text + "','" + txtSeatNumber.Text + "', '" + dateTimePicker1.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + "PHILIPPINE AIRLINES" + "')";
            string insert23 = "INSERT into seat_table (price, nickname, seat, reservation_date, date_from, airline) VALUES ('" + "P3,500" + "','" + txtNickName.Text + "','" + txtSeatNumber.Text + "', '" + dateTimePicker1.Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + "PHILIPPINE AIRLINES" + "')";
            //string sinsertPayment = "INSERT into seat_table (price) VALUES ('" + "P1,500" + "')"; ;
            //string sinsertPayment1 = "INSERT into seat_table (price) VALUES ('" + "P2,500" + "')";
            //string sinsertPayment2 = "INSERT into seat_table (price) VALUES ('" + "P3,500" + "')";
            form2txt = txtNickName.Text;
            form21txt = txtSeatNumber.Text;
            form22txt = dateTimePicker1.Text;
            int confuse = 300;
            DialogResult dialog = MessageBox.Show("This can't be undone, proceed?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (txtNickName.Text != string.Empty && txtSeatNumber.Text != string.Empty && dateTimePicker1.Text != string.Empty)
                {
                    if (/*Convert.ToInt32(txtSeatNumber.Text) <= 300*/ int.TryParse(txtSeatNumber.Text, out confuse ) && confuse <= 300)
                    {
                        if (radioButton1.Checked)
                        {
                            if (Convert.ToInt32(txtSeatNumber.Text) <= 99 && Convert.ToInt32(txtSeatNumber.Text) >= 1)
                            {
                                form23txt = "CEBU PACIFIC";
                                execQ(insert);
                                dataView();
                            }
                            if (Convert.ToInt32(txtSeatNumber.Text) <= 200 && Convert.ToInt32(txtSeatNumber.Text) >= 100)
                            {
                                form23txt = "CEBU PACIFIC";
                                execQ(insertONE);
                                dataView();
                            }
                            else if (Convert.ToInt32(txtSeatNumber.Text) <= 300 && Convert.ToInt32(txtSeatNumber.Text) >= 200)
                            {
                                form23txt = "CEBU PACIFIC";
                                execQ(insertTWO);
                                dataView();
                            }

                        }

                        else if (radioButton2.Checked)
                    {
                        if (Convert.ToInt32(txtSeatNumber.Text) <= 99 && Convert.ToInt32(txtSeatNumber.Text) >= 1)
                            {
                                form23txt = "AIR-ASIA";
                                execQ(insert11);
                            dataView();
                            }
                        if (Convert.ToInt32(txtSeatNumber.Text) <= 200 && Convert.ToInt32(txtSeatNumber.Text) >= 100)
                            {
                                form23txt = "AIR-ASIA";
                                execQ(insert12);
                            dataView();
                            }
                        else if (Convert.ToInt32(txtSeatNumber.Text) <= 300 && Convert.ToInt32(txtSeatNumber.Text) >= 200)
                            {
                                form23txt = "AIR-ASIA";
                                execQ(insert13);
                            dataView();
                            }
                    }

                    else if (radioButton3.Checked)
                    {
                        if (Convert.ToInt32(txtSeatNumber.Text) <= 99 && Convert.ToInt32(txtSeatNumber.Text) >= 1)
                            {
                                form23txt = "PHILIPPINE AIRLINES";
                                execQ(insert21);
                            dataView();
                            }
                        if (Convert.ToInt32(txtSeatNumber.Text) <= 200 && Convert.ToInt32(txtSeatNumber.Text) >= 100)
                            {
                                form23txt = "PHILIPPINE AIRLINES";
                                execQ(insert22);
                            dataView();
                            }
                        else if (Convert.ToInt32(txtSeatNumber.Text) <= 300 && Convert.ToInt32(txtSeatNumber.Text) >= 200)
                            {
                                form23txt = "PHILIPPINE AIRLINES";
                                execQ(insert23);
                                dataView();
                            }
                    }
                }

                else
                {
                    MessageBox.Show("SEAT LIMIT EXCEEDED!");
                }
                    txtSeatNumber.Text = string.Empty;
                    txtNickName.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("Empty fields");
                }
                txtSeatNumber.Text = string.Empty;
                txtNickName.Text = string.Empty;


            }
            else if (dialog == DialogResult.No)
            {

            }
        }
            private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSeatNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
