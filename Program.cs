using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using myTechnics.myExamples;

namespace AirBaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] arm1 = new string[] 
            { 
                "Пушка ГШ-30-1 - 1 шт", 
                "УР «воздух-воздух» Р-27Р - 6 шт", 
                "УР «воздух-воздух» Р-73 - 3 шт",
                "авиабомбы АБ-100/АБ - 20 шт" 
            };

            string[] arm2 = new string[]
            {
                "Пушка ГШ-30-1 - 1 шт",
                "УР «воздух-воздух» Р-27Р - 5 шт",
                "УР «воздух-воздух» Р-73 - 3 шт",
                "авиабомбы АБ-500/АБ - 6 шт"
            };


            string[] arm3 = new string[]
         {
                "Пушка ГШ-23Л - 1 шт",
                "УР «воздух-воздух» 23Л - 2 шт",
                "УР «воздух-воздух» 23М - 2 шт",
                "авиабомбы С-24Б - 2 шт"
         };

            string[] arm4 = new string[]
      {
                "Пушка ГШ-23Л - 1 шт",
                "УР «воздух-воздух» 23Л - 2 шт",
                "УР «воздух-воздух» 23М - 2 шт",
                "авиабомбы С-16Б - 5 шт"
      };
            //Technics AN_24tech = new Technics("АН - 24", "\"Завод им. Антонова\"",45, 4.5f, 17.2f,13.4f);          
            AircraftTechnics AN_24base = new AircraftTechnics("АН-24", "\"Завод им. Антонова\"", 14.6f, 8.3f, 29.2f, 23.5f, 440, 2000, 21, 8000);
            AircraftTechnics IL_76base = new AircraftTechnics("ИЛ-76","\"Авиационный комплекс имени С. В. Ильюшина\"",145,3.4f, 3.45f, 24.54f, 850, 5500, 195, 10200);
            AircraftTechnics SU_27base = new AircraftTechnics("СУ-27", "\"ОАО \"Компания «Сухой»\"", 16, 5.93f, 14.7f, 21f, 2500, 1380, 22, 18000);
            AircraftTechnics MIG_23base = new AircraftTechnics("МиГ-23", "\"ОКБ имени Яковлева\"", 10.5f, 5f, 7.78f, 16.7f, 2500, 1450, 20, 17700);
            Technics ZiL_131base = new Technics("ЗиЛ-131", "Завод им. Ленина", 6.79f, 2.9f,2.5f,7.04f);
            Technics URAL_4320base = new Technics("Урал-4320", "Автомобильный завод «УРАЛ»", 8.7f, 2.87f,2.5f,7.36f);

            AirBase Mirhorod = new AirBase("123-я истребительная бригада","г. Миргород, Полтавская обл.");
            Mirhorod.addTechnic(new CargoAirplane(AN_24base, 21414, 52));
            Mirhorod.addTechnic(new CargoAirplane(AN_24base, 14257, 52));
            Mirhorod.addTechnic(new CargoAirplane(IL_76base, 7163455, 321));

            Mirhorod.addTechnic(new Fighters(SU_27base, arm1, 123466));
            Mirhorod.addTechnic(new Fighters(SU_27base, arm1, 127553));
            Mirhorod.addTechnic(new Fighters(SU_27base, arm2, 229012));
            Mirhorod.addTechnic(new Fighters(MIG_23base, arm3, 321456));
            Mirhorod.addTechnic(new Fighters(MIG_23base, arm4, 441456));

            Mirhorod.addTechnic(new AutoTechnics(ZiL_131base, 80, 41.9f, 10.5f, 23451));
            Mirhorod.addTechnic(new AutoTechnics(ZiL_131base, 80, 41.9f, 10.5f, 24566));
            Mirhorod.addTechnic(new AutoTechnics(URAL_4320base, 85, 45f, 15f, 11233));


        Begin:
            Console.WriteLine($"\t\t{Mirhorod.Name}({Mirhorod.Description})\n\n" +
                $"\tОбщие количество техники: {Mirhorod.getAllTechCounter()}\n" +
                $"\tИз них :\n" +
                $"\tАвиотехника: {Mirhorod.getAirCounter()}\n" +
                $"\tАвтотехника: {Mirhorod.getAutoCount()}\n\n" +
                $"\tНажмите:\n" +
                $"\t 1 - для просмотра всей техники\n" +
                $"\t 2 - для просмотра авиотехники\n" +
                $"\t 3 - для просмотра автотехники\n" +
                $"\t 4 - выход из программы");

            ConsoleKeyInfo keyPress = Console.ReadKey();
            switch (keyPress.KeyChar)
            {
                case '1':
                    {
                        Console.Clear();
                        goto All;
                    }
                case '2':
                    {
                        Console.Clear();
                        goto Avia;                        
                    }
                case '3':
                    {
                        Console.Clear();
                        goto Auto;                       
                    }
                case '4':
                    {
                        Console.Clear();
                        goto End;                       
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t!!! Неправильный ввод\n");
                        goto Begin;
                    }
            }

        All:
            Console.WriteLine($"\t\t{Mirhorod.Name}({Mirhorod.Description})\n\n");
            Mirhorod.ShowAllTechnics();
            Console.WriteLine($"\tНажмите:\n" +
                $"\t 1 - для возврата в главное меню\n" +              
                $"\t 2 - выход из программы");

            keyPress = Console.ReadKey();
            switch (keyPress.KeyChar)
            {
                case '1':
                    {
                        Console.Clear();
                        goto Begin;
                    }
                case '2':
                    {
                        Console.Clear();
                        goto End;
                    }               
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t!!! Неправильный ввод\n");
                        goto All;
                    }
            }

        Avia:
            Console.WriteLine($"\t\t{Mirhorod.Name}({Mirhorod.Description})\n\n" +
                $"\tОбщие количество самолетов: {Mirhorod.getAirCounter()}\n" +
                $"\tИз них :\n" +
                $"\tИстребители: {Mirhorod.getFightCount()}\n" +
                $"\tГрузвые самолеты: {Mirhorod.getCargoCount()}\n\n" +
                $"\tНажмите:\n" +
                $"\t 1 - для просмотра истребителей\n" +
                $"\t 2 - для просмотра грузовых самолетов\n" +
                $"\t 3 - для возврата в главное меню\n" +
                $"\t 4 - выход из программы");

            keyPress = Console.ReadKey();
            switch (keyPress.KeyChar)
            {
                case '1':
                    {
                        Console.Clear();
                        goto Fighters;
                    }
                case '2':
                    {
                        Console.Clear();
                        goto Cargo;
                    }
                case '3':
                    {
                        Console.Clear();
                        goto Begin;
                    }
                case '4':
                    {
                        Console.Clear();
                        goto End;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t!!! Неправильный ввод\n");
                        goto Avia;

                    }
            }


        Fighters:
            Console.WriteLine($"\t\t{Mirhorod.Name}({Mirhorod.Description})\n\n");
               // $"\tИстребители:\n");
                Mirhorod.ShowFighters();
            Console.WriteLine($"\tНажмите:\n" +
                $"\t 1 - для просмотра авиотехники\n" +
                $"\t 2 - для возврата в главное меню\n" +
                $"\t 3 - выход из программы");

            keyPress = Console.ReadKey();
            switch (keyPress.KeyChar)
            {
                case '1':
                    {
                        Console.Clear();
                        goto Avia;
                    }
                case '2':
                    {
                        Console.Clear();
                        goto Begin;
                    }
                case '3':
                    {
                        Console.Clear();
                        goto End;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t!!! Неправильный ввод\n");
                        goto Fighters;
                    }
            }

        Cargo:
            Console.WriteLine($"\t\t{Mirhorod.Name}({Mirhorod.Description})\n\n");
                
            Mirhorod.ShowCargo();
            Console.WriteLine($"\tНажмите:\n" +
                $"\t 1 - для просмотра авиотехники\n" +
                $"\t 2 - для возврата в главное меню\n" +
                $"\t 3 - выход из программы");

            keyPress = Console.ReadKey();
            switch (keyPress.KeyChar)
            {
                case '1':
                    {
                        Console.Clear();
                        goto Avia;
                    }
                case '2':
                    {
                        Console.Clear();
                        goto Begin;
                    }
                case '3':
                    {
                        Console.Clear();
                        goto End;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t!!! Неправильный ввод\n");
                        goto Cargo;
                    }
            }

        Auto:
            Console.WriteLine($"\t\t{Mirhorod.Name}({Mirhorod.Description})\n\n");                
            Mirhorod.ShowAuto();
            Console.WriteLine($"\tНажмите:\n" +
                $"\t 1 - для возврата в главное меню\n" +
                $"\t 2 - выход из программы");

            keyPress = Console.ReadKey();
            switch (keyPress.KeyChar)
            {              
                case '1':
                    {
                        Console.Clear();
                        goto Begin;
                    }
                case '2':
                    {
                        Console.Clear();
                        goto End;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t!!! Неправильный ввод\n");
                        goto Auto;
                    }
            }

        End: Console.WriteLine("\n\t\tДо свидания\n");
        }
    }
}
