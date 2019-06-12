using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseEitherField
    {

        public static void CollectInput(Farm farm, ISeedAndCompost plant)
        {
            Console.Clear();


            Console.Clear();
            List<IFlowering> capacityList = farm.NaturalAndPlowed.Where(thingy => thingy.NumberOfPlants < thingy.Capacity).ToList();

            if (capacityList.Count == 0)
            {
                Console.WriteLine("All natural fields and plowed are at capacity or you have not created a natural or plowed field. Please create a natural or plowed field.");
                Console.WriteLine("Please press enter to return to the main menu.");
                Console.ReadLine();
                return;
            }
            else
            {
                for (int i = 0; i < capacityList.Count; i++)
                {
                    if (capacityList[i].NumberOfPlants < capacityList[i].Capacity)
                    {
                        // if the grazing field is not over capacity, display and chose it
                        Console.WriteLine($"Number of plants in {capacityList[i].TypeString()} field {i + 1}: {capacityList[i].NumberOfPlants}");
                    }

                }
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