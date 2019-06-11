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
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IChicken animal)
        {
            Console.Clear();
            List<ChickenHouse> capacityList = farm.ChickenHouses.Where(thingy => thingy.NumberOfAnimals < thingy.Capacity).ToList();

            if (capacityList.Count == 0)
            {
                Console.WriteLine("All Chicken Houses are at capacity or you have not created a Chicken House. Please create a new Chicken House.");
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
                        // Console.WriteLine($"{i + 1}. Number of animals in grazing field {i + 1}: {capacityList[i].NumberOfAnimals}");
                        Console.WriteLine($"{i + 1}. Number of chickens in chicken house {i + 1}: {capacityList[i].NumberOfAnimals}");
                    }
                    else
                    {
                        Console.WriteLine("All Chicken Houses are at capacity, please create a new Chicken House.");
                        Console.WriteLine("Please press enter to return to the main menu.");
                        Console.ReadLine();
                        return;
                    }
                }

                Console.WriteLine();

                // How can I output the type of animal chosen here?
                Console.WriteLine($"Place the animal where?");

                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Congrats on buying a new animal!");
                Thread.Sleep(1000);
                capacityList[choice - 1].AddResource(animal);

                /*
                    Couldn't get this to work. Can you?
                    Stretch goal. Only if the app is fully functional.
                 */
                // farm.PurchaseResource<IGrazing>(animal, choice);

            }
        }
    }
}