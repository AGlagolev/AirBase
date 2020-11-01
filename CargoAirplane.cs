using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTechnics
{
    namespace myExamples
    {
        class CargoAirplane : AircraftTechnics
        {
            private int _serialNumber;      // серийный номер
            private int _сargoСompartmentVolume; // объем грузовой кабины
            //private static int _cargoCounter =0;
            /// <CONSTRUCTORS>
            public CargoAirplane(
                string model = "ХЗ",
                string manuf = "ХЗ",
                float weight = 0,
                float height = 0,
                float width = 0,
                float length = 0,
                int cruisingSpeed = 0,
                int rangeOfFlight = 0,
                int maxWeight = 0,
                int maxFlightAltitude = 0,
                int sn = 0,
                int сargoСompartmentVolume = 0
                ) : base(model, manuf, weight, height, width, length, cruisingSpeed, rangeOfFlight, maxWeight, maxFlightAltitude)
            {
                SerialNumber = sn;
                CargoСompartmentVolume = сargoСompartmentVolume;               
                _technicsCounter++;
            }
            public CargoAirplane(
                AircraftTechnics another,
                int sn = 0,
                int сargoСompartmentVolume = 0
                ) : base(another)
            {
                SerialNumber = sn;
                CargoСompartmentVolume = сargoСompartmentVolume;
                _technicsCounter++;
            }
            /// </CONSTRUCTORS>
            public int SerialNumber
            {
                get { return this._serialNumber; }
                set
                {
                    if (value >= 0 && value < int.MaxValue)
                    {
                        this._serialNumber = value;
                    }
                }
            }
            public int CargoСompartmentVolume
            {
                get { return this._сargoСompartmentVolume; }
                set
                {
                    if (value >= 0 && value < int.MaxValue)
                    {
                        this._сargoСompartmentVolume = value;
                    }
                }

            }
            //public static int getCargoCounter()
            //{
            //    return _cargoCounter;
            //}
            public new void Show()
            {
                base.Show();
                Console.Write($"\tсерийный номер: {SerialNumber}\n\t" +
                    $"объем грузовой кабины: {CargoСompartmentVolume} м.куб\n");
                Console.WriteLine();
            }
        }
    }
}
