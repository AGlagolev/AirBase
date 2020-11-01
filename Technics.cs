using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTechnics
{
    namespace myExamples
    {
        class Technics
        {
            
            private string _model;           // модель техники
            private string _manufacturer;   // завод изготовитель
            private float _weight;   //вес
            private float _height;   //высота    
            private float _width;    //ширина
            private float _length;   //длина
            protected static int _technicsCounter = 0; // общий счетчик техники
            /// <CONSTRUCTORS>
            public Technics(string model = "ХЗ", string manuf = "ХЗ", float weight = 0, float height = 0, float width = 0, float length = 0)
            {

                // ИСПРАВИТЬ
                Model = model;
                Manufacturer = manuf;
                Weight = weight;
                Height = height;
                Width = width;
                Length = length;
                //TechnicsCounter++;

            }

            public Technics(Technics another)
            {
                Model = another._model;
                //SerialNumber = another.SerialNumber;
                Manufacturer = another.Manufacturer;
                Weight = another.Weight;
                Height = another.Height;
                Width = another.Width;
                Length = another.Length;
                //TechnicsCounter++;
            }
            /// </CONSTRUCTORS>

            /// <DESTRUCTORS>
                 
            /// </DESTRUCTORS>

            public string Model
            {
                get { return this._model; }
                set
                {
                    if (value.Length >= 2)
                    {
                        this._model = value;
                    } 
                }
            }

            public string Manufacturer
            {
                get { return this._manufacturer; }
                set
                {
                    if (value.Length >= 2 && value.Length < 50)
                    {
                        this._manufacturer = value;
                    }
                }

            }

            public float Weight
            {
                get { return this._weight;}
                set
                {
                    if (value >=0 && value <= 300)
                    {
                        this._weight = value;
                    }
                }
            }
            
            public float Height
            {
                get { return this._height; }
                set
                {
                    if (value >= 0 && value <= 50)
                    {
                        this._height = value;
                    }
                }
            }

            public float Width
            {
                get { return this._width; }
                set
                {
                    if (value >= 0 && value <= 100)
                    {
                        this._width = value;
                    }
                }
            }

            public float Length
            {
                get { return this._length; }
                set
                {
                    if (value >= 0 && value <= 100)
                    {
                        this._length = value;
                    }
                }
            }
            public static int getTechCounter()
            {
                return _technicsCounter;
            }
            public void Show()
            {
                //Console.WriteLine();
                Console.Write($"\tмодель: {Model}\n\t" +
                              $"завод изготовитель: \"{Manufacturer}\"\n\t" +
                              $"высота: {Height} м.\n\t" +
                              $"ширина: {Width} м.\n\t" +
                              $"длина: {Length} м.\n\t" +
                              $"вес: {Weight} т.\n");
            }

        }
    }
}
