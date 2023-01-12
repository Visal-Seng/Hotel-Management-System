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

namespace TermProjectWindow.UserControlRoom
{
    public partial class UserControlRoom : UserControl
    {
        private List<ClsRoom> Rooms= new List<ClsRoom>();
        private IOManager ioManager = new IOManager();
        private string fileRoom = "room";
        public UserControlRoom()
        {
            InitializeComponent();
        }

        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            Rooms = ioManager.Load<List<ClsRoom>>(fileRoom);
            if(Rooms == null)
            {
                Rooms = new List<ClsRoom>();
            }
            Clear();
        }
        public int GetId()
        {
            ClsRoom room = Rooms.OrderByDescending(r => r.Id).FirstOrDefault();
            if(room != null)
            {
                return room.Id + 1;
            }
            return 1;
        }
        private void Clear()
        {
            textBoxId.Text = GetId().ToString();
            comboBoxType.Text = "";
            comboBoxFree.Text = "";
            textBoxRoomNo.Text = "";

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageAddRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
