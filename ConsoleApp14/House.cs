using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    public class House : IDisplayData
    {
        private int area;

        protected Door door = new Door();

        public Door GetDoor
        {
            get
            {
                return this.door;
            }
            set
            {
                if (door == null)
                {
                    Console.WriteLine("It is mandatory to set a door for the house.");
                }
                this.door = value;
            }
        }

        public virtual int Area
        {
            get { return area; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Area should be grater than zero sqm.");
                }
                this.area = value;
            }
        }

        public House(Door door)
        {
            this.door = door;
        }

        public House(int area, Door door)
        {
            this.Area = area;
            this.door = door;

        }

        public virtual void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {this.area} sqm.");
        }

    }

}
