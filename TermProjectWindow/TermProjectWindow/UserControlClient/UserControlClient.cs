using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TermProjectWindow.Cls;

namespace TermProjectWindow.UserControlClient
{
    public partial class UserControlClient : UserControl
    {
        private List<ClsClient> Clients= new List<ClsClient>();
        private IOManager ioManager = new IOManager();
        private string fileClient = "client";
        public UserControlClient()
        {
            InitializeComponent();
        }
        private void UserControlClient_Load(object sender, EventArgs e)
        {
            Clients = ioManager.Load<List<ClsClient>>(fileClient);
            if (Clients == null)
            {
                Clients = new List<ClsClient>();
            }
            Clear();
        }
        private void tabPageAddClient_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public  void RefreshClientById(int clientId)
        {
            ClsClient temp = Clients.Where(c=>c.Id== clientId).FirstOrDefault();
            if (temp != null)
            {
                textBoxId.Text = temp.Id.ToString();
                textBoxFirstName.Text = temp.FirstName;
                textBoxLastName.Text = temp.LastName;
                textBoxPhone.Text = temp.Phone;
                textBoxAddress.Text = temp.Address;
            }
        }
        public int GetId()
        {
            ClsClient client = Clients.OrderByDescending(c => c.Id).FirstOrDefault();
            if(client != null)
            {
                return client.Id + 1;
            }
            return 1;
        }
        private void Clear()
        {
            textBoxId.Text = GetId().ToString();
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text))
            {
                MessageBox.Show("Please input first name!");
                return;
            }
            else if(string.IsNullOrEmpty(textBoxLastName.Text))
            {
                MessageBox.Show("Please input last name!");
                return ;
            }
            else if (string .IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Please input phone!");
                return ;
            }
            else if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Please input address!");
                return ;
            }
            int id = int.Parse(textBoxId.Text);
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text; 
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;   
            ClsClient client = new ClsClient(id,firstName,lastName,phone,address);
            ClsClient temp = Clients.Where(c=>c.Phone == phone).FirstOrDefault();
            if(temp == null)
            {
                Clients.Add(client);
                ioManager.Save(Clients, fileClient);
                MessageBox.Show("Added");
                Clear();
            }
        }

        private void tabPageSearchClient_Click(object sender, EventArgs e)
        {
            Clients = ioManager.Load<List<ClsClient>>(fileClient);
            if (Clients == null)
            {
                Clients = new List<ClsClient>();
            }
            dataGridViewClient.DataSource = Clients;
        }

        private void dataGridViewClient_DoubleClick(object sender, EventArgs e)
        {
             if(dataGridViewClient.SelectedRows.Count > 0)
            {
                int clientId = (int)dataGridViewClient.SelectedRows[0].Cells[0].Value;
                RefreshClientById(clientId);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text))
            {
                MessageBox.Show("Please input firstname!");
            }
            else if (string.IsNullOrEmpty(textBoxLastName.Text))
            {
                MessageBox.Show("Please input last name!");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Please input phone!");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Please input address!");
                return;
            }
            int clientId = int.Parse(textBoxId.Text);
            ClsClient client = Clients.Where(c=>c.Id== clientId).FirstOrDefault();
            if(client != null) 
            { 
                client.FirstName= textBoxFirstName.Text;
                client.LastName= textBoxLastName.Text;
                client.Phone= textBoxPhone.Text;
                client.Address = textBoxAddress.Text;
                ioManager.Save(Clients, fileClient);
                MessageBox.Show("Updated");
                Clear();  
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text))
            {
                MessageBox.Show("Please input firstname!");
            }
            else if (string.IsNullOrEmpty(textBoxLastName.Text))
            {
                MessageBox.Show("Please input last name!");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxPhone.Text))
            {
                MessageBox.Show("Please input phone!");
                return;
            }
            else if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Please input address!");
                return;
            }
            int clientId = int.Parse(textBoxId.Text);
            ClsClient client = Clients.Where(c => c.Id == clientId).FirstOrDefault();
            if (client != null)
            {
                Clients.Remove(client);
                MessageBox.Show("Deleted!");
                Clear();
            }
        }
    }
}
