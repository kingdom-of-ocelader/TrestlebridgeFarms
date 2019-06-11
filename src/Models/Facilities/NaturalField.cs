using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<INatural>, IFlowering
    {
        private int _capacity = 60;
        private Guid _id = Guid.NewGuid();
        private List<INatural> _plants = new List<INatural>();
        public int NumberOfPlants {
            get{
                return _plants.Count;
            }
        }

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public void AddResource(INatural plant)
        {
            _plants.Add(plant);
        }
        public void AddResource(List<INatural> plants)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural Field ID:{shortId}, has {this._plants.Count} plant(s)\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}