using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {

            House smallHouse = new SmallApartment( new Door() { Color = "red" });
            var person = new Person(smallHouse);
            person.Name = "Ioana";
            person.ShowData();
        }
    }
}
