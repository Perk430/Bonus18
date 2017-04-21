using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;

        //No arguments constructor setting data members to default values
        public Car()
        {
            make = "";
            model = "";
            year = 2017;
            price = 72000;

        }
        //Constructor with four arguments matching the above order
        public Car(string makeInput, string modelInput, 
            int yearInput, double PriceInput)
        {
            make = makeInput;
            model = modelInput;
            year = yearInput;
            price = PriceInput;
        }

        public string CarMake

        {
            set
            {
                make = value;
            }

            get
            {
                return make;
            }
        }

        public string CarModel
        {
            set
            {
                model = value;
            }
            get
            {
                return model;
            }
        }

        public int CarYear
        {
            set
            {
                year = value;
            }

            get
            {
                return year;
            }
        }

        public double CarPrice

        {
            set
            {
                price = value;
            }

            get
            {
                return price;
            }
        }
    }
}


