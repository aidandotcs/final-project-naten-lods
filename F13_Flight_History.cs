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
    public partial class F13_Flight_History : Form
    {
        public F13_Flight_History()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource = localhost; port= 3306; database = finals; username = root; password = ; Convert Zero DateTime=true");
       public void dataView()
        {
            string selectQuery = "SELECT * FROM seat_table WHERE nickname = '"+txtSecurity.Text+"'";
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

        private void F13_Flight_History_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSubmitSecurity_Click(object sender, EventArgs e)
        {
            MySqlCommand readCommand = new MySqlCommand("SELECT * FROM seat_table WHERE nickname = '"+txtSecurity.Text+"'", connection);
            connection.Open();
            MySqlDataReader reader = readCommand.ExecuteReader();

            if (reader.Read())
            {
                reader.Close();
               // string readThemShit = "SELECT * FROM seat_table WHERE nickname = '" + txtSecurity.Text + "'";
               DataTable table = new DataTable();
               MySqlDataAdapter adapter = new MySqlDataAdapter(readCommand);
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {

            }
            //reader.Close();
            connection.Close();
            readCommand.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F4Content f4Content = new F4Content();
            f4Content.Show();
            this.Hide();
        }

    }
    }

