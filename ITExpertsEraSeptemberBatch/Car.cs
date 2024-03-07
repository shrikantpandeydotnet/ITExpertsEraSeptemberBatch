using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraSeptemberBatch
{
    // syntax
    public class Car
    {
        //variable 
        public int speed = 10;

        // create new variable

        public int noOfSeats = 6;
        public string color = "Red";

        // Properties 
        //Syntax
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public int NoofSeats { get; set; }

        // Methods 

        public void Accelerator(int pressure)
        {
            int currentSpeed = speed * pressure;

            Console.WriteLine("Current Speed of the car is " + currentSpeed);
            
        }

        public void Brake(int pressure)
        {
            int currentSpeed = speed / pressure;


            Console.WriteLine("Current Speed of the car is " + currentSpeed);

        }

        public void Clutch(int pressure)
        {
            int currentSpeed = speed;

            Console.WriteLine("Current Speed of the car is " + currentSpeed);

        }


    }
}
