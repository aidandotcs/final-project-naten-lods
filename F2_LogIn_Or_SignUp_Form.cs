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
using System.Net.Mail;
using System.Net;


namespace lets_gooo
{
    public partial class F2_LogIn_Or_SignUp_Form : Form
    {
        public F2_LogIn_Or_SignUp_Form()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; database=finals; username=root; password=;");

        
        public void querySelect()
        {
            string select = "SELECT * FROM login";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(select, connection);
            adapter.Fill(table);
        }
        public void execQ(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("You can now Log-In");
                }
                else
                {
                    MessageBox.Show("Sign-Up Failed");
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
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            F3_SignUp_Form form3 = new F3_SignUp_Form();
            form3.Show();
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM login WHERE username = '"+txtUserName.Text+"' AND password = '"+txtPassword.Text+"'", connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                //MessageBox.Show("success");
                F4Content content = new F4Content();
                content.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("failed");
            }

            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            reader.Close();
            command.Dispose();
            connection.Close();
        }

        private void btnBacktoMap_Click(object sender, EventArgs e)
        {
            F1DashBoard backtoMap = new F1DashBoard();
            //backtoMap.Show();
            //this.Hide();

            DialogResult dialog = MessageBox.Show("BACK TO MAIN MENU?", "" , MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                backtoMap.Show();
                this.Hide();
            }
            else if (dialog == DialogResult.No)
                    {
                //
            }
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
