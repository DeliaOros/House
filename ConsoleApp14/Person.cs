using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    public class Person : IDisplayData
    {
        private House house;

        public string Name { get; set; }

        public Person(House house)
        {
            this.house = house;
        }

        public House House
        {
            get
            {
                return this.house;
            }
            set
            {
                if (house == null)
                {
                    Console.WriteLine("House can't be null, the person must have a house.");
                }
                this.house = value;
            }
        }

        public void ShowData()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.Write($"Info about {this.Name}'s home: ");
            this.House.ShowData();
            Console.Write($"Info about the house's door: ");
            this.House.GetDoor.ShowData();
        }
    }
}
