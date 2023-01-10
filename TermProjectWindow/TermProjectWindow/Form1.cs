using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProjectWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            userControlClient2.Show();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            userControlClient2.Hide();
            userControlRoom2.Show();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            userControlClient1.Hide();
            userControlRoom2.Hide();
            userControlReservation1.Show();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            userControlClient1.Hide();
            userControlRoom2.Hide();
            userControlReservation1.Hide();
            userControl1.Show();
        }
    }
}
