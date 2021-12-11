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
    public partial class F5_BookAnotherFlight : Form
    {
        public F5_BookAnotherFlight()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource=localhost; port = 3306; database= finals; username = root; password =; ");
        private void F5_BookAnotherFlight_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            F7_MANILAtoDAVAO manilaDavao = new F7_MANILAtoDAVAO();
            manilaDavao.Show();
            this.Hide();
         }

        private void button3_Click(object sender, EventArgs e)
        {
            F8_Manila_to_Cebu f8_Manila_To_Cebu = new F8_Manila_to_Cebu();
            f8_Manila_To_Cebu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F2_LogIn_Or_SignUp_Form f2_LogIn_Or_SignUp_Form = new F2_LogIn_Or_SignUp_Form();
            DialogResult dialog = MessageBox.Show("This will Log you out. Proceed?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                f2_LogIn_Or_SignUp_Form.Show();
                this.Hide();
            }
            else if (dialog == DialogResult.No)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            F9_manila_to_Palawan f9 = new F9_manila_to_Palawan();
            f9.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            F10_manila_to_Bicol f10 = new F10_manila_to_Bicol();
            f10.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            F11_Manila_to_Leyte f11 = new F11_Manila_to_Leyte();
            f11.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            F12_Manila_to_Cagayan f12 = new F12_Manila_to_Cagayan();
            f12.Show();
            this.Hide();
        }
    }
    }

