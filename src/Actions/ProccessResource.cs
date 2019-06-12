using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ProccessResource
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Seed Harvester");
            Console.WriteLine("2. Meat Proccessor");
            Console.WriteLine("3. Egg Gatherer");
            Console.WriteLine("4. Composter");
            Console.WriteLine("5. Feather Plucker");

            Console.WriteLine();
            Console.WriteLine("Please Select Equipment to use.");

            Console.Write("> ");
            string choice = Console.ReadLine();
            // switch (Int32.Parse(choice))
            // {
            //     case 1:
            //         ChooseGrazingField.CollectInput(farm, new Cow());
            //         break;
            //     case 2:
            //         ChooseMeatProccesor.CollectInput(farm, IMeatProducing );
            //         break;
            //     case 3:
            //         ChooseDuckHouse.CollectInput(farm, new Duck());
            //         break;
            //     case 4:
            //         ChooseChickenHouse.CollectInput(farm, new Chicken());
            //         break;
            //     case 5:
            //         ChooseGrazingField.CollectInput(farm, new Pig());
            //         break;

            //     default:
            //         break;
            // }

        }
    }
}