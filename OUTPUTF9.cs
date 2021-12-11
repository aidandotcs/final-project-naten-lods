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
    public partial class OUTPUTF9 : Form
    {
        public OUTPUTF9()
        {
            InitializeComponent();
        }

        private void OUTPUTF9_Load(object sender, EventArgs e)
        {
            lblnickname.Text = F9_manila_to_Palawan.form2txt;
            lblseat.Text = F9_manila_to_Palawan.form21txt;
            lblDeparture.Text = F9_manila_to_Palawan.form22txt;
            lblAirLine.Text = F9_manila_to_Palawan.form23txt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F1DashBoard dash = new F1DashBoard();
            dash.Show();
            this.Hide();
        }
    }
}
