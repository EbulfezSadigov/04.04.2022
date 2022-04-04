using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    class Hotel
    {
        public string Name { get; set; }
        private Room[] rooms = new Room[0];
        public Hotel(string name,int size)
        {
            Name = name;
            rooms = new Room[size];
        }
        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);
            rooms[rooms.Length - 1] = room;
        }
        public void Reserve()
        {
            
        }

        public Room this [int index]
        {
            get
            {
                return rooms[index];
            }
            set
            {
                rooms[index] = value;
            }
        }
    }
}
