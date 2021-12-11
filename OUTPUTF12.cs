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
    public partial class OUTPUTF12 : Form
    {
        public OUTPUTF12()
        {
            InitializeComponent();
        }

        private void OUTPUTF12_Load(object sender, EventArgs e)
        {
            lblnickname.Text = F12_Manila_to_Cagayan.form2txt;
            lblseat.Text = F12_Manila_to_Cagayan.form21txt;
            lblDeparture.Text = F12_Manila_to_Cagayan.form22txt;
            lblAirLine.Text = F12_Manila_to_Cagayan.form23txt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F1DashBoard dash = new F1DashBoard();
            dash.Show();
            this.Hide();
        }
    }
}
