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
    public partial class F3_SignUp_Form : Form
    {
        public F3_SignUp_Form()
        {
            InitializeComponent();
            LoadCaptcha();
        }

        int num = 0;
        private void LoadCaptcha()
        {
            //throw new NotImplementedException();
            Random random1 = new Random();
            num = random1.Next(100, 999);
            var img = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("Times New Roman", 100, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(img);
            graphics.DrawString(num.ToString(), font, Brushes.BurlyWood, new Point(0, 0));
            pictureBox1.Image = img;


        }

        MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; database=finals; username=root; password=;");

        public void dataView()
        {
            string selectQuery = "SELECT * FROM login";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);

        }

        //for try catch sign up
        public void execQ(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            try
            {
                F2_LogIn_Or_SignUp_Form bukas = new F2_LogIn_Or_SignUp_Form();
                connection.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("YOU CAN NOW LOG-IN!");
                    bukas.Show();
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insert = "INSERT INTO login(username,password, FirstName,LastName, MiddleName, City, State, Street, PhoneNumber, Gender) VALUES ('" + txtUserName.Text + "', '" + txtPassword.Text + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtMiddleName.Text+ "', '" + txtCity.Text + "', '" + txtState.Text + "', '" + txtStreet.Text + "', '" + txtPhoneNumber.Text + "', '" + txtGender.Text + "')";
            dataView();

            if (txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty && txtMiddleName.Text !=string.Empty && txtPhoneNumber.Text != string.Empty && txtGender.Text != string.Empty && txtCity.Text != string.Empty && txtState.Text != string.Empty && txtStreet.Text != string.Empty && txtUserName.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                //execQ(insert);
                if (txtVerify.Text == num.ToString())
                {
                    execQ(insert);
                }
                else
                {
                 MessageBox.Show("CAPTCHA FAILED");
                    LoadCaptcha();
                }
            }

            else
            {
                MessageBox.Show("EMPTY FIELDS");
                LoadCaptcha();

            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {

        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBacktoDashboard_Click(object sender, EventArgs e)
        {
            F2_LogIn_Or_SignUp_Form f2 = new F2_LogIn_Or_SignUp_Form();
            DialogResult dialog = MessageBox.Show("BACK TO DASHBOARD?", "", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                f2.Show();
                this.Hide();
            }
            else if (dialog == DialogResult.No)
            {
                //do nothing
            }
        }
    }
    }

