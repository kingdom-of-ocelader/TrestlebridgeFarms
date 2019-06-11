using System;
using System.Linq;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChooseGrazingField {
        
        public static void CollectInput (Farm farm, IGrazing animal) {
            Console.Clear();
            
       
            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                if(farm.GrazingFields[i].NumberOfAnimals < farm.GrazingFields[i].Capacity ){
                    // if the grazing field is not over capacity, display and chose it
                    Console.WriteLine ($"{i + 1}. Number of animals in grazing field {i + 1}: {farm.GrazingFields[i].NumberOfAnimals}");
                }else{
                    Console.WriteLine("All grazing fields are at capacity, please create a new grazing field.");
                    Console.WriteLine("Please press enter to return to the main menu.");
                    Console.ReadLine();
                    break;
                }
            }

            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the animal where?");

            Console.Write ("> ");
            int choice = Int32.Parse(Console.ReadLine ());
            Console.WriteLine("Congrats on buying a new animal!");
            Thread.Sleep(1000);

            farm.GrazingFields[choice - 1].AddResource(animal);

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}