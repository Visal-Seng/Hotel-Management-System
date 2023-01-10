using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectWindow.Cls
{
    public class ClsRoom
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Free { get; set; }
        public ClsRoom() { }
        public ClsRoom(int id, string type, string name, string free)
        {
            Id = id;
            Type = type;
            Name = name;
            Free = free;
        }
    }
}
