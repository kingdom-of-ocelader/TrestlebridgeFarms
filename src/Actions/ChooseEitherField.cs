using System;
using System.Linq;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChooseEitherField
    {

        public static void CollectInput(Farm farm, ISeedAndCompost plant)
        {
            Console.Clear();


            for (int i = 0; i < farm.NaturalAndPlowed.Count; i++)
            {
                string typeString = farm.NaturalAndPlowed[i].TypeString();
                Console.WriteLine($"{i + 1}. Number of plants in {typeString} field {i + 1}: {farm.NaturalAndPlowed[i].NumberOfPlants}");
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Plant the seeds where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            int index = choice - 1;

            farm.PlantSeedInChosenField(plant, index);

            Console.WriteLine("You planted a seed!");
            Thread.Sleep(1000);


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}