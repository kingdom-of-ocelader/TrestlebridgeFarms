using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class SunFlower : IResource, IPlowed, INatural, ISeedAndCompost
    {
        private int _seedsProduced = 520;

        private double _compostProduced = 21.62;


        public string Type { get; } = "Sunflower";

        public double Harvest () {
            return _seedsProduced;
        }
        public double Compost () {
            return _compostProduced;
        }

        public override string ToString () {
            return $"Sunflower. So Pretty!";
        }
    }
}