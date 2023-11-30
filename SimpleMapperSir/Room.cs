using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMapperSir
{
    public class Room
    {
        public int RoomNumber { get; set; }
        
        public List<Window> Windows { get; set; }
        public string[] Features { get; set; }

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }
    }
}
