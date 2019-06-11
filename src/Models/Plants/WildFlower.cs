using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class WildFlower : IResource, INatural
    {
        private double _compostProduced = 30.3;
        public string Type { get; } = "WildFlower";

        public double Compost () {
            return _compostProduced;
        }

        public override string ToString () {
            return "Wildfolowers are wild and flowering.";
        }
    }
}