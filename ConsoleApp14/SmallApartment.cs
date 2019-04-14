using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    public class SmallApartment : House
    {
        public SmallApartment(Door door) : base(50, door)
        {
        }

        public SmallApartment(int area, Door door) : base(area, door)
        {
            if (area > 50)
            {
                throw new ArgumentOutOfRangeException("The area is up to 50 sqm, review input for area!");
            }
            this.Area = area;
        }

        public override int Area
        {
            set
            {
                if (value <= 50)
                {
                    base.Area = value;
                }
            }
        }

        public override void ShowData()
        {
            Console.WriteLine($"I am a small apartment, my area is {this.Area} m2");
        }
    }
}
