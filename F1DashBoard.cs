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
    public partial class F1DashBoard : Form
    {
        public F1DashBoard()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }
        MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; database=finals; username=root; password=;");

        public void querySelect()
        {
            string select = "SELECT * FROM login";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(select, connection);
            adapter.Fill(table);
        }


        private void btnSearchAdress_Click(object sender, EventArgs e)
        {
            string street = txtStreet.Text;
            string city = txtCity.Text;
            string state = txtSTATE.Text;

            StringBuilder queryAddress = new StringBuilder();
            queryAddress.Append("http://google.com/maps?q=");

            if (street != string.Empty)
            {
                queryAddress.Append(street + "," + "+");
            }
            if (city != string.Empty)
            {
                queryAddress.Append(city + "," + "+");
            }
            if (state != string.Empty)
            {
                queryAddress.Append(state + "," + "+");
            }
            webBrowser1.Navigate(queryAddress.ToString());
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBook_Click(object sender, EventArgs e)
        {
            F2_LogIn_Or_SignUp_Form form = new F2_LogIn_Or_SignUp_Form();
            form.Show();
            this.Hide();
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("EXIT?", "", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialog == DialogResult.No)
            {
                //
            }
        }
    }
}
