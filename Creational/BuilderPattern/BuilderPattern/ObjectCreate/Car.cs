using BuilderPattern.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.ObjectCreate
{
    public class Car
    {
        public int? NumberOfWheels { get; set; }
        public SeatBelt SeatBelt { get; set; }
        public string Color { get; set; }
        public WindScreen WindScreen { get; set; }
        public Engine Engine { get; set; }
        public Car(int NumberOfWheels, SeatBelt SeatBelt, string Color, WindScreen WindScreen, Engine Engine)
        {
            this.NumberOfWheels = NumberOfWheels;
            this.SeatBelt = SeatBelt;
            this.Color = Color;
            this.WindScreen = WindScreen;
            this.Engine = Engine;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(string.Format("Number of wheel: {0} - SeatBelt: {1} - Color: {2} - WindScreen: {3} - Engine: {4}",
                NumberOfWheels == 0 ? 0 : NumberOfWheels, SeatBelt == null ? "No Data" : SeatBelt.Brand,
                Color == null ? "No Data" : Color, WindScreen == null ? "No Data" : WindScreen.Name, 
                Engine == null ? "No Data" : Engine.Name));
        }
    }
}
