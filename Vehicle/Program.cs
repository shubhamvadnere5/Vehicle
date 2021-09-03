using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car
    {
        string color = "Red";
        int model = 3434;
        
        public void drive()
        {
            Console.WriteLine("Driving");
            
        }
        public static void brake()
        {
            Console.WriteLine("new message added");
        }
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.model);
            myObj.drive();
            brake();
            Console.Read();
        }
    }
}
