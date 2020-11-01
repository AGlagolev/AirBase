using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTechnics
{
    namespace myExamples
    {
        class AutoTechnics : Technics
        {
            private int _maxSpeed; // максимальная скорсть
            private float _gasMileage; // расход бензина
            private float _liftingCapacity;     // грузоподъемность
            private int _serialNumber;  // серийный номер
           // protected static int _autoTechnicsCounter = 0;


            /// <CONSTRUCTORS>
            public AutoTechnics(
                string model = "ХЗ",
                string manuf = "ХЗ",
                float weight = 0,
                float height = 0,
                float width = 0,
                float length = 0,
                int maxSpeed = 0,
                float gasMileage = 0,
                float liftingCapacity = 0,
                int serialNumber = 0
                ) : base(model, manuf, weight, height, width, length)
            {
                MaxSpeed = maxSpeed;
                GasMileage = gasMileage;
                LiftingCapacity = liftingCapacity;
                SerialNumber = serialNumber;
                _technicsCounter++;

            }

            public AutoTechnics(

                Technics AnotherTech,
                int maxSpeed = 0,
                float gasMileage = 0,
                float liftingCapacity = 0,
                int serialNumber = 0

                ) : base(AnotherTech)
            {

                MaxSpeed = maxSpeed;
                GasMileage = gasMileage;
                LiftingCapacity = liftingCapacity;
                SerialNumber = serialNumber;
                _technicsCounter++;
            }

            /// </CONSTRUCTORS>


            

            public int MaxSpeed
            {
                get { return this._maxSpeed; }
                set
                {
                    if (value >= 0 && value < 300)
                    {
                        this._maxSpeed = value;
                    }
                }
            }
            public float GasMileage
            {
                get { return this._gasMileage; }
                set
                {
                    if (value >= 0 && value < 200)
                    {
                        this._gasMileage = value;
                    }
                }
            }


            
            public float LiftingCapacity
            {
                get { return this._liftingCapacity; }
                set
                {
                    if (value >= 0 && value < 200)
                    {
                        this._liftingCapacity = value;
                    }
                }
            }
            
            public int SerialNumber
            {
                get { return this._serialNumber; }
                set
                {
                    if (value >= 0 && value < 1000000)
                    {
                        this._serialNumber = value;
                    }
                }
            }
            //public static int getAutoTechCounter()
            //{
            //    return _autoTechnicsCounter;
            //}
            public new void Show()
            {
                base.Show();
                Console.Write($"\tмаксимальная скорость: {MaxSpeed} км/ч\n\t" +
                    $"расход топлива: {GasMileage} л/100 км.\n\t" +
                    $"грузоподемность: {LiftingCapacity} т.\n\t" +
                    $"серийный номер: {SerialNumber}\n");
                Console.WriteLine();

            }
        }
    }
}
