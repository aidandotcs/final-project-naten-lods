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
    public partial class OUTPUTF10 : Form
    {
        public OUTPUTF10()
        {
            InitializeComponent();
        }

        private void OUTPUTF10_Load(object sender, EventArgs e)
        {
            lblnickname.Text = F10_manila_to_Bicol.form2txt;
            lblseat.Text = F10_manila_to_Bicol.form21txt;
            lblDeparture.Text = F10_manila_to_Bicol.form22txt;
            lblAirLine.Text = F10_manila_to_Bicol.form23txt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F1DashBoard dash = new F1DashBoard();
            dash.Show();
            this.Hide();
        }
    }
}
