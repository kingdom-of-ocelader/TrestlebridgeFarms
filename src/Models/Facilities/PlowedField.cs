using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Models.Facilities{
    public class PlowedField: IFacility<IPlowed>, IFlowering
    {
        private int _capacity { get; set; } = 65;
        private Guid _id = Guid.NewGuid();
        private List<IPlowed> _plants = new List<IPlowed>();
        public double Capacity {
            get{
                return _capacity;
            }
        }
        public int NumberOfPlants {
            get{
                return _plants.Count;
            }
        }
        public void AddResource (IPlowed plant)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }
        public void AddResource (List<IPlowed> plants)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowed Field ID:{shortId}, has {this._plants.Count} plant(s)\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}