using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChooseDuckHouse {
        public static void CollectInput (Farm farm, IDucks animal) {
            Console.Clear();

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                Console.WriteLine ($"{i + 1}. Number of ducks in duck house {i + 1}: {farm.DuckHouses[i].NumberOfAnimals}");
            }

            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the animal where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ());

            farm.DuckHouses[choice - 1].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}