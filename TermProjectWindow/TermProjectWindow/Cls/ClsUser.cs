using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectWindow.Cls
{
    public class ClsUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ClsUser() { }
        public ClsUser(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }
    }
}
