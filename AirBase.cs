using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTechnics
{
    namespace myExamples
    {
        class AirBase
        {
            private string _name;
            private string _description; 
            private Technics[] _technics;

            /// <CONSTRUCTORS>
            public AirBase(string name, string description)                
            {
                _name = name;
                _description = description;
                _technics = new Technics[0];
            }

            
            /// </CONSTRUCTORS>
            public string Name
            {
                get { return this._name; }
                
            }

            public string Description
            {
                get { return this._description; }
                
            }

            public void addTechnic(Technics item)
            {
                Technics[] buff = new Technics[_technics.Length + 1];
                Array.Copy(_technics, buff, _technics.Length);
                buff[_technics.Length] = item;
                _technics = buff;
            }

            public int getAllTechCounter()
            {
                return _technics.Length;
            }
            public int getAirCounter()
            {
                int c = 0;
                foreach (var item in _technics)
                    if (item is Fighters || item is CargoAirplane)
                    {
                        c++;
                    }
                return c; ;
            }
            public int getFightCount()
            {
                int c = 0;
                foreach (var item in _technics)
                    if (item is Fighters)
                    {
                        c++;
                    }
                return c;
            }
            public int getCargoCount()
            {
                int c = 0;
                foreach (var item in _technics)
                    if (item is CargoAirplane)
                    {
                        c++;
                    }
                return c;
            }
            public int getAutoCount()
            {
                int c = 0;
                foreach (var item in _technics)
                    if (item is AutoTechnics)
                    {
                        c++;
                    }
                return c;
            }


            public void ShowAllTechnics()
            {
                int i = 1;
                Console.WriteLine("Истребители:\n");
                foreach (var item in _technics)
                    if (item is Fighters)
                    {
                        Console.WriteLine($"\t{i}");
                        ((Fighters)item).Show();
                        i++;
                    }
              
                Console.WriteLine("Грузовые самолеты:\n");
                foreach (var item in _technics)
                    if (item is CargoAirplane)
                    {
                        Console.WriteLine($"\t{i}");
                        ((CargoAirplane)item).Show();
                        i++;
                    }
                Console.WriteLine("Автомобили:\n");
                foreach (var item in _technics)
                    if (item is AutoTechnics)
                    {
                        Console.WriteLine($"\t{i}");
                        ((AutoTechnics)item).Show();
                        i++;
                    }
                Console.WriteLine();
            }

            public void ShowFighters()
            {
                int i = 1;
                Console.WriteLine("Истребители:\n");
                foreach (var item in _technics)
                    if (item is Fighters)
                    {
                        Console.WriteLine($"\t{i}");
                        ((Fighters)item).Show();
                        i++;
                    }
            }

            public void ShowCargo()
            {
                int i = 1;
                Console.WriteLine("Грузовые самолеты:\n");
                foreach (var item in _technics)
                    if (item is CargoAirplane)
                    {
                        Console.WriteLine($"\t{i}");
                        ((CargoAirplane)item).Show();
                        i++;
                    }
            }

            public void ShowAuto()
            {
                int i = 1;
                Console.WriteLine("Автомобили:\n");
                foreach (var item in _technics)
                    if (item is AutoTechnics)
                    {
                        Console.WriteLine($"\t{i}");
                        ((AutoTechnics)item).Show();
                        i++;
                    }
            }

        }
    }
}
