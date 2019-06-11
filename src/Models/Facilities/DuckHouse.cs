using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class DuckHouse : IFacility<IDucks>
    {
        private int _capacity = 12;
        private Guid _id = Guid.NewGuid();
        public int NumberOfAnimals {
            get{
                return _animals.Count;
            }
        }

        private List<IDucks> _animals = new List<IDucks>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (IDucks animal)
        {
            if (_animals.Count < _capacity) {
            _animals.Add(animal);
            } else {
            }
        }

        public void AddResource (List<IDucks> animals)
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