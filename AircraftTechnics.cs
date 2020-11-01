using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTechnics
{
    namespace myExamples
    {
        class AircraftTechnics : Technics
        {
            private int _cruisingSpeed; // крейсерская скорость
            private int _rangeOfFlight; // дальность полета
            private int _maxWeight;     // максимальная взлетная масса
            private int _maxFlightAltitude; // максимальная высота полета
            //protected static int _aircraftTechnicsCounter = 0;
            /// <CONSTRUCTORS>
            public AircraftTechnics(
                string model = "ХЗ", 
                string manuf = "ХЗ", 
                float weight = 0, 
                float height = 0, 
                float width = 0, 
                float length = 0,
                int cruisingSpeed = 0,
                int rangeOfFlight = 0,
                int maxWeight = 0,
                int maxFlightAltitude = 0
                ) :base(model, manuf, weight, height, width, length)
            {                
                CruisingSpeed = cruisingSpeed;
                RangeOfFlight = rangeOfFlight;
                MaxWeight = maxWeight;
                MaxFlightAltitude = maxFlightAltitude;
                
            }

            public AircraftTechnics(
                
                Technics AnotherTech,
                int cruisingSpeed = 0,
                int rangeOfFlight = 0,
                int maxWeight = 0,
                int maxFlightAltitude = 0

                ) :base(AnotherTech)
            {
                CruisingSpeed = cruisingSpeed;
                RangeOfFlight = rangeOfFlight;
                MaxWeight = maxWeight;
                MaxFlightAltitude = maxFlightAltitude;
                
            }

            public AircraftTechnics(AircraftTechnics another)
            {
                this.Model = another.Model;
                this.Manufacturer = another.Manufacturer;
                this.Height = another.Height;
                this.Length = another.Length;
                this.Width = another.Width;
                this.Weight = another.Weight;
                this.CruisingSpeed = another.CruisingSpeed;
                this.RangeOfFlight = another.RangeOfFlight;
                this.MaxWeight = another.MaxWeight;
                this.MaxFlightAltitude = another.MaxFlightAltitude;
                
            }
            /// </CONSTRUCTORS>

            public int CruisingSpeed
            {
                get {return this._cruisingSpeed; }
                set
                {
                    if (value >= 0 && value < 10000)
                    {
                        this._cruisingSpeed = value;
                    }
                }
            }
            public int RangeOfFlight 
            {
                get {return this._rangeOfFlight; }
                set
                {
                    if (value >= 0 && value < 15000)
                    {
                        this._rangeOfFlight = value;
                    }
                }
            }
            public int MaxWeight 
            {
                get {return this._maxWeight; }
                set
                {
                    if (value >= 0 && value < 20000)
                    {
                        this._maxWeight = value;
                    }
                }
            }
            public int MaxFlightAltitude
            {
                get { return this._maxFlightAltitude; }
                set
                {
                    if (value >= 0 && value < 100000)
                    {
                        this._maxFlightAltitude = value;
                    }
                }
            }
            //public static int getAirTechCounter()
            //{
            //    return _aircraftTechnicsCounter;
            //}
            public new void Show()
            {
                base.Show();
                Console.Write($"\tкрейсерская скорость: {CruisingSpeed} км/ч\n\t" +
                    $"дальность полета: {RangeOfFlight} км.\n\t" +
                    $"максимальная взлетная масса: {MaxWeight} т.\n\t" +
                    $"максимальная высота полета: {MaxFlightAltitude} м.\n");
                
            }
        }
    }
}
