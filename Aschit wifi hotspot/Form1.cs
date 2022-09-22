using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aschit_wifi_hotspot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("cmd", String.Format("/c {0}&{1}&{2}", "netsh wlan set hostednetwork mode=allow ssid=" + txtname.Text + "key=" + txtpassword.Text, "netsh wlan start hostednetwork", "exit "));
                MessageBox.Show("congrats");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", "/c netsh wlan stop hostednetwork");
            MessageBox.Show("suddenly wifi stops");
        }

        private void lnkshowpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txtpassword.UseSystemPasswordChar = false;
        }

        private void lnkforgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txtpassword.UseSystemPasswordChar =true;
        }
    }
}
