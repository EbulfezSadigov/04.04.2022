using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Models
{
    class Room
    {
        private readonly int Id = 1;
        public string Name { get; set; }
        public int Price { get; set; }
        private int _personCapacity;

        public Room(string name, int price, int personcapacity, int id)
        {
            Name = name;
            Price = price;
            PersonCapacity = personcapacity;
            if (id > 0)
            {
                Id = id;
                id++;
            }
        }

        public int PersonCapacity
        {
            get
            { return _personCapacity; }
            set
            {
                if (value > 0 && value < 5)
                {
                    _personCapacity = value;
                }
            }
        }
        public bool IsAvaliable()
        {
            return true;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Price is " + Price);
            Console.WriteLine("Person capacity is " + PersonCapacity);
        }
        public override string ToString()
        {
            return $"{Name}-{Price}-{PersonCapacity}";
        }
        public int id
        {
            get { return Id; }
        }
    }
}
