using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Models.Facilities
{
    public class EitherField : IFacility<INatural>, IFacility<IFlowering>, IFlowering
    {
        private int _capacity = 2;
        private Guid _id = Guid.NewGuid();
        private List<IFlowering> _plants = new List<IFlowering>();
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

        public int sunflowers{
            get{
                int count = 0; 
                foreach(IFlowering plant in _plants){
                    if(plant is SunFlower){
                        count ++;
                    }
                }
                return count;
            }
        }

        public int wildflowers{
            get{
                int count = 0; 
                foreach(IFlowering plant in _plants){
                    if(plant is WildFlower){
                        count ++;
                    }
                }
                return count;
            }
        }
        // public void AddResource(IFlowering plant)
        // {
        //     _plants.Add(plant);
        // }

        // public void AddResource(List<INatural> plants)
        // {
        //     // TODO: implement this...
        //     throw new NotImplementedException();
        // }

        // public void AddResource(IFlowering plant)
        // {
        //     _plants.Add((IFlowering)plant);
        // }


        // public void AddResource(List<IFlowering> plants)
        // {
        //     // TODO: implement this...
        //     throw new NotImplementedException();
        // }


        // public override string ToString()
        // {
        //     StringBuilder output = new StringBuilder();
        //     string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

        //     output.Append($"Natural Field ID:{shortId}, has {this._plants.Count} plant(s)\n");
        //     this._plants.ForEach(a => output.Append($"   {a}\n"));

        //     return output.ToString();
        // }
        public string TypeString(){
            return "Natural";
        }
    }
}