using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    public class Door : IDisplayData
    {
        private string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value.Length < 3 || value == null)
                {
                    Console.WriteLine("Check color value, shoukdn't be less than three characters.");
                }
                else
                {
                    this.color = value;
                }
            }
        }
        

        public void ShowData()
        {
            Console.WriteLine($"I am a door, my color is {this.color}."); ;
        }
    }
}



