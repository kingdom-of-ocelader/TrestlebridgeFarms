using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class WildFlower : IResource, INatural;
    {
        private int _compostProduced = 40;
        public string Type { get; } = "WildFlower";

        public double Compost () {
            return _compostProduced;
        }

        public override string ToString () {
            return $"Sesame. Yum!";
        }
    }
}