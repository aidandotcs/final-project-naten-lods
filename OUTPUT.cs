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
    public partial class OUTPUT : Form
    {

        public OUTPUT()
        {
            InitializeComponent();
        }

        private void OUTPUT_Load(object sender, EventArgs e)
        {
            lblnickname.Text = F7_MANILAtoDAVAO.form2txt;
            lblseat.Text = F7_MANILAtoDAVAO.form21txt;
            lblDeparture.Text = F7_MANILAtoDAVAO.form22txt;
            lblAirLine.Text = F7_MANILAtoDAVAO.form23txt;

            /*lblnickname.Text = F8_Manila_to_Cebu.form2txt;
            lblseat.Text = F8_Manila_to_Cebu.form21txt;
            lblDeparture.Text = F8_Manila_to_Cebu.form22txt;
            lblAirLine.Text = F8_Manila_to_Cebu.form23txt;

            lblnickname.Text = F9_manila_to_Palawan.form2txt;
            lblseat.Text = F9_manila_to_Palawan.form21txt;
            lblDeparture.Text = F9_manila_to_Palawan.form22txt;
            lblAirLine.Text = F9_manila_to_Palawan.form23txt;

            lblnickname.Text = F10_manila_to_Bicol.form2txt;
            lblseat.Text = F10_manila_to_Bicol.form21txt;
            lblDeparture.Text = F10_manila_to_Bicol.form22txt;
            lblAirLine.Text = F10_manila_to_Bicol.form23txt;

            lblnickname.Text = F11_Manila_to_Leyte.form2txt;
            lblseat.Text = F11_Manila_to_Leyte.form21txt;
            lblDeparture.Text = F11_Manila_to_Leyte.form22txt;
            lblAirLine.Text = F11_Manila_to_Leyte.form23txt;

            lblnickname.Text = F12_Manila_to_Cagayan.form2txt;
            lblseat.Text = F12_Manila_to_Cagayan.form21txt;
            lblDeparture.Text = F12_Manila_to_Cagayan.form22txt;
            lblAirLine.Text = F12_Manila_to_Cagayan.form23txt;
            */


        }

        private void button2_Click(object sender, EventArgs e)
        {
            F1DashBoard dash = new F1DashBoard();
            dash.Show();
            this.Hide();
        }
    }
}
