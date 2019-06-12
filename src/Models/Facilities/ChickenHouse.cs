using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IChicken>
    {
        private int _capacity = 2;
        private Guid _id = Guid.NewGuid();
        public int NumberOfAnimals
        {
            get
            {
                return _animals.Count;
            }
        }
        private List<IChicken> _animals = new List<IChicken>();
        public int chickenCount
        {
            get
            {
                int count = 0;
                foreach (IChicken an in _animals)
                {
                    if (an is Chicken)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IChicken animal)
        {
            _animals.Add(animal);
        }

        public void AddResource(List<IChicken> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken house ID:{shortId}, has {this._animals.Count} chicken(s)\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}