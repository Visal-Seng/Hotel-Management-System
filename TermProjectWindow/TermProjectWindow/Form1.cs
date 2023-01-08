using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TermProjectWindow.UserSetting;

namespace TermProjectWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControlClient1.Show();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            userControl1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            userControlReservation1.Show(); 
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            user
        }
    }
}
