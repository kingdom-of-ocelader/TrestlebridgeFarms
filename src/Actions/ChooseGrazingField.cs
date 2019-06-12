using System;
using System.Linq;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using System.Collections.Generic;
using Trestlebridge.Models.Facilities;


namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Console.Clear();
            List<GrazingField> capacityList = farm.GrazingFields.Where(thingy => thingy.NumberOfAnimals < thingy.Capacity).ToList();



            if (capacityList.Count == 0)
            {
                Console.WriteLine("All grazing fields are at capacity or you have not created a grazing field. Please create a new grazing field.");
                Console.WriteLine("Please press enter to return to the main menu.");
                Console.ReadLine();
                return;
            }
            else
            {
                for (int i = 0; i < capacityList.Count; i++)
                {
                    if (capacityList[i].NumberOfAnimals < capacityList[i].Capacity)
                    {
                        // if the grazing field is not over capacity, display and chose it
                        Console.WriteLine($" Grazing field #{i + 1} has: ");
                        Console.WriteLine($"{capacityList[i].cows} Cows");
                        Console.WriteLine($"{capacityList[i].sheep} Sheep");
                        Console.WriteLine($"{capacityList[i].goats} Goats");
                        Console.WriteLine($"{capacityList[i].ostriches} Ostriches");
                        Console.WriteLine($"{capacityList[i].pigs} Pigs");
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - ");

                    }

                }
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Congrats on buying a new animal!");
            Thread.Sleep(1000);

            // if(id.ToString() == "1"){

            // }            
            capacityList[choice - 1].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}