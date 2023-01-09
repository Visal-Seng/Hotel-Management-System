using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectWindow.Cls
{
    public class ClsClient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public ClsClient() { }
        public ClsClient(int id, string firstName, string lastName, string phone, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Address = address;
        }
    }
}
