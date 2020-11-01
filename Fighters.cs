using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTechnics
{
    namespace myExamples
    {
        class Fighters : AircraftTechnics
        {
            private int _serialNumber;      // серийный номер
            private string[] _armament = new string[0]; // вооружение
            // private static int _figtersCounter = 0;
            /// <CONSTRUCTORS>
            public Fighters(
                string[] arm,
                int sn = 0,
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
                ) : base(model, manuf, weight, height, width, length, cruisingSpeed, rangeOfFlight, maxWeight, maxFlightAltitude)
            {
                SerialNumber = sn;
                _armament = arm;
                _technicsCounter++;
            }

            public Fighters(AircraftTechnics another, string[] arm, int sn = 0) : base(another) 
            {
                _armament = arm;
                SerialNumber = sn;
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
            public void addArmament(string arm)
            {
                if (arm.Length >= 3)
                {
                    string[] buff = new string[_armament.Length + 1];
                    Array.Copy(_armament, buff, _armament.Length);
                    buff[_armament.Length] = arm;
                    _armament = buff;
                }                             
            }

            public string[] GetArm()
            {
                
                return _armament;
            }
            //public static int getFightCount()
            //{
            //    return _figtersCounter;
            //}
            public new void Show()
            {
                
                base.Show();
                Console.Write($"\tсерийный номер: {SerialNumber}\n\t" +
                    $"\tВооружение: \n");
                foreach (var item in GetArm())
                {
                    Console.Write($"\t{item}\n");
                }
                Console.WriteLine();
            } 
        }
    }
}
