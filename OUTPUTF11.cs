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
    public partial class OUTPUTF11 : Form
    {
        public OUTPUTF11()
        {
            InitializeComponent();
        }

        private void OUTPUTF11_Load(object sender, EventArgs e)
        {
            lblnickname.Text = F11_Manila_to_Leyte.form2txt;
            lblseat.Text = F11_Manila_to_Leyte.form21txt;
            lblDeparture.Text = F11_Manila_to_Leyte.form22txt;
            lblAirLine.Text = F11_Manila_to_Leyte.form23txt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F1DashBoard dash = new F1DashBoard();
            dash.Show();
            this.Hide();
        }
    }
}
