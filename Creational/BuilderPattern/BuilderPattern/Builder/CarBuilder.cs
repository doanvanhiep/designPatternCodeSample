using BuilderPattern.CarParts;
using BuilderPattern.ObjectCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public class CarBuilder
    {
        public int NumberOfWheels { get; set; }
        public SeatBelt SeatBelt { get; set; }
        public string Color { get; set; }
        public WindScreen WindScreen { get; set; }
        public Engine Engine { get; set; }

        public CarBuilder AddWheels(int numberOfWheels)
        {
            this.NumberOfWheels = numberOfWheels;
            return this;
        }

        public CarBuilder AddSeatBelt(SeatBelt seatBelt)
        {
            this.SeatBelt = seatBelt;
            return this;
        }

        public CarBuilder AddColor(string color)
        {
            this.Color = color;
            return this;
        }

        public CarBuilder AddWindScreen(WindScreen windScreen)
        {
            this.WindScreen = windScreen;
            return this;
        }

        public CarBuilder AddEngine(Engine engine)
        {
            this.Engine = engine;
            return this;
        }

        public Car Build()
        {
            return new Car(NumberOfWheels, SeatBelt, Color, WindScreen, Engine);
        }

    }
}
