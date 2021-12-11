using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lets_gooo
{
    public partial class OUTPUTone : Form
    {
        public OUTPUTone()
        {
            InitializeComponent();
        }

        private void OUTPUTone_Load(object sender, EventArgs e)
        {
            lblnickname.Text = F8_Manila_to_Cebu.form2txt;
            lblseat.Text = F8_Manila_to_Cebu.form21txt;
            lblDeparture.Text = F8_Manila_to_Cebu.form22txt;
            lblAirLine.Text = F8_Manila_to_Cebu.form23txt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F1DashBoard dash = new F1DashBoard();
            dash.Show();
            this.Hide();
        }
    }
}
