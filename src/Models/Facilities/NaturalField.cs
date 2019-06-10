using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<INatural>
    {
        private int _capacity { get; set; }
        private Guid _id = Guid.NewGuid();
        private List<INatural> _animals = new List<INatural>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public void AddResource(INatural animal)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public void AddResource(List<INatural> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck house {shortId} has {this._animals.Count} ducks\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}