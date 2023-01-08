using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TermProjectWindow.UserSetting
{
    public partial class userControl : UserControl
    {
        public userControl()
        {
            InitializeComponent();
        }
        private void clear()
        {
            textBoxUserName.Clear();
            textBoxPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
