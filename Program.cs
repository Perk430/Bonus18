using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class CarApp
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Welcome to the Grand Circus Motors admin console! \n\n");

            //Console.WriteLine("How many cars are you entering?  ");
            Console.WriteLine("Enter Car1 Make \n");
            string make=  Console.ReadLine();

            Console.WriteLine("Enter Car1 Model \n");
            string model = Console.ReadLine();

            Console.WriteLine("Enter Car1 year \n");
            int year = int.Parse(Console.ReadLine());//Parse to read the "integer" value

            Console.WriteLine("Enter Car1 price");
            double price = double.Parse(Console.ReadLine());//Parse to read the "double" value


            Car Car1 = new Car(make, model, year, price);

            Console.WriteLine(Car1.CarMake + "\t" + Car1.CarModel + "\t" + Car1.CarYear + "\t" + Car1.CarPrice);
                 
        }
    }
}
