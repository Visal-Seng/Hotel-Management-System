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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            userControlClient1.Show();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            userControlClient1.Hide();
            userControlRoom1.Show();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlReservation1.Show();
        }
    }
}
