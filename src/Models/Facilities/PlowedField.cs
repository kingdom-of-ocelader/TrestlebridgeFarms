using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities{
    public class PlowedField: IFacility<ISeedProducing>{
        private int _capacity { get; set; } = 65;
        private Guid _id = Guid.NewGuid();
        private List<ISeedProducing> _plants = new List<ISeedProducing>();
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
        public void AddResource (ISeedProducing plant)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }
        public void AddResource (List<ISeedProducing> animals) 
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

    }
}