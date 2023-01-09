using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TermProjectWindow.Cls;

namespace TermProjectWindow.UserSetting
{
    public partial class userControl : UserControl
    {
        private List<ClsUser> Users = new List<ClsUser>();
        private IOManager ioManager = new IOManager();
        private string fileUser = "user";
        
        
        public userControl()
        {
            InitializeComponent();
        }
        private void userControl_Load(object sender, EventArgs e)
        {
            Users = ioManager.Load<List<ClsUser>>(fileUser);
            if (Users == null)
            {
                Users = new List<ClsUser>();
            }
            clear();
        }
        public void RefreshUserById(int userId)
        {
            ClsUser temp = Users.Where(u=>u.Id== userId).FirstOrDefault();
            if(temp != null)
            {
                textBoxId.Text = temp.Id.ToString();
                textBoxUserName.Text = temp.Username;
                textBoxPassword.Text = temp.Password;
            }
        }
        public int GetId()
        {
            ClsUser user = Users.OrderByDescending(u=>u.Id).FirstOrDefault();
            if(user != null)
            {
                return (user.Id+1);
            }
            return 1;
        }
  
        private void clear()
        {
            textBoxId.Text = GetId().ToString();
            textBoxUserName.Text= "";
            textBoxPassword.Text= "";

        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text))
            {
                MessageBox.Show("Please input username!");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Please input password");
                return;
            }
            int id = int.Parse(textBoxId.Text);
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text; 
            ClsUser user = new ClsUser(id, username, password);
            ClsUser temp = Users.Where(u=>u.Username== username).FirstOrDefault();
            if(temp == null)
            {
                Users.Add(user);
                ioManager.Save(Users, fileUser);
                MessageBox.Show("Added");
                clear();
            }   
        }
     
        private void tabPageAddUser_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPageSearchUser_Click(object sender, EventArgs e)
        {
            Users = ioManager.Load<List<ClsUser>>(fileUser);
            if (Users == null)
            {
                Users = new List<ClsUser>();
            }
            dataGridViewSearchUser.DataSource = Users;
        }

        private void dataGridViewSearchUser_DoubleClick(object sender, EventArgs e)
        {
            if(dataGridViewSearchUser.SelectedRows.Count > 0)   
            {
                int userId = (int)dataGridViewSearchUser.SelectedRows[0].Cells[0].Value;
                RefreshUserById(userId);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text))
            {
                MessageBox.Show("Please input username!");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Please input password");
                return;
            }
            int userId = int.Parse(textBoxId.Text);
            ClsUser user = Users.Where(u=>u.Id==userId).FirstOrDefault();
            if(user != null) 
            {
                user.Username = textBoxUserName.Text;
                user.Password = textBoxPassword.Text;
                ioManager.Save(Users, fileUser);
                MessageBox.Show("Updated");
                clear();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUserName.Text))
            {
                MessageBox.Show("Please input username!");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Please input password");
                return;
            }
            int userId = int.Parse(textBoxId.Text);
            ClsUser user = Users.Where(u => u.Id == userId).FirstOrDefault();
            if (user != null)
            {
                Users.Remove(user);
                ioManager.Save(Users, fileUser);
                MessageBox.Show("Removed");
                clear();
            }
        }
    }
}
