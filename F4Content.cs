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
    public partial class F4Content : Form
    {
        public F4Content()
        {
            InitializeComponent();
        }

        private void btnBookAnotherFlight_Click(object sender, EventArgs e)
        {
            F5_BookAnotherFlight bookAnotherFlight = new F5_BookAnotherFlight();
            bookAnotherFlight.Show();
            this.Hide();
        }

        private void btnFlightHistory_Click(object sender, EventArgs e)
        {
            F13_Flight_History f13 = new F13_Flight_History();
            f13.Show();
            this.Hide();
        }
    }
}
