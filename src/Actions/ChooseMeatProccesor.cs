using System;
using System.Linq;
using System.Threading;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using System.Collections.Generic;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions{
    public class ChooseMeatProccesor{
        public static void CollectInput(Farm farm, IMeatProducing meat){
        foreach(GrazingField field in farm.GrazingFields){
           int i = 1;
            Console.WriteLine($"Grazing field #{i} has: {field.NumberOfAnimals} ready to butcher");
            i++;
        }
    }
}}