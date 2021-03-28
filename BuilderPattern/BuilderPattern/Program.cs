using BuilderPattern.Builder;
using BuilderPattern.ObjectCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carBuilder = new CarBuilder()
                .AddWheels(4)
                .AddSeatBelt(new CarParts.SeatBelt("USA"))
                .AddColor("Red")
                .AddEngine(new CarParts.Engine("Germany"))
                .AddWindScreen(new CarParts.WindScreen("No Branch"))
                .Build();
            carBuilder.DisplayInfo();

            Car carNomal = new Car(4, new CarParts.SeatBelt("No"), "Blue", 
                new CarParts.WindScreen("Wind"), new CarParts.Engine("No Engine"));
            carNomal.DisplayInfo();
            Console.ReadKey();

        }
    }
}
