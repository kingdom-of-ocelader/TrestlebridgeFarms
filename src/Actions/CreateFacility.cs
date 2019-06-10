using System;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions {
    public class CreateFacility {
        public static void CollectInput (Farm farm) {
            Console.WriteLine ("1. Grazing field");
            Console.WriteLine ("2. Natural Field");
            Console.WriteLine ("3. Plowed field");
            Console.WriteLine ("4. Chicken House");
            Console.WriteLine ("5. Duck House");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

            switch (Int32.Parse(input))
            {
                case 1:
                    Console.WriteLine("Congrats you added a grazing field");
                    Thread.Sleep(3000);
                    farm.AddGrazingField(new GrazingField());
                    break;
                case 2:
                    Console.WriteLine("Congrats you've added a natural field");
                    Thread.Sleep(3000);
                    farm.AddNaturalField(new NaturalField());

                    break;
                case 3:
                    Console.WriteLine("Congrats you've added a plowed field");
                    Thread.Sleep(3000);
                    farm.AddPlowedField(new PlowedField());

                    break;
                   case 4:
                    Console.WriteLine("Congrats you added a chicken house");
                    Thread.Sleep(3000);
                    farm.AddChickenHouse(new ChickenHouse());break;

                case 5:
                    Console.WriteLine("Congrats you added a duck house.");
                    Thread.Sleep(3000);
                    farm.AddDuckHouse(new DuckHouse());
                    break;
                default:
                    break;
            }
        }
    }
}