using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 6;
        private Guid _id = Guid.NewGuid();
        // public List<IGrazing> cowList = new List<IGrazing>();
        // public List<Pig> pigList = new List<Pig>();
        // public List<Ostrich> ostrichList = new List<Ostrich>();
        // public List<Sheep> sheepList = new List<Sheep>();
        // public List<Goat> goatList = new List<Goat>();
        
        public int cows{
            get{
            int count = 0;
            foreach(IGrazing an in _animals){
                if(an is Cow){
                    count++;
                }
            }
            return count;
        }}
        public int pigs{
            get{
            int count = 0;
            foreach(IGrazing an in _animals){
                if(an is Pig){
                    count++;
                }
            }
            return count;
        }}
        public int goats{
            get{
            int count = 0;
            foreach(IGrazing an in _animals){
                if(an is Goat){
                    count++;
                }
            }
            return count;
        }}
        public int ostriches{
            get{
            int count = 0;
            foreach(IGrazing an in _animals){
                if(an is Ostrich){
                    count++;
                }
            }
            return count;
        }}
        public int sheep{
            get{
            int count = 0;
            foreach(IGrazing an in _animals){
                if(an is Sheep){
                    count++;
                }
            }
            return count;
        }}
    

        private List<IGrazing> _animals = new List<IGrazing>();
        public double NumberOfAnimals
        {
            get
            {
                return _animals.Count;
            }
        }
        public List<IGrazing> animalList
        {
            get
            {
                return _animals;
            }
        }

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }
        public Guid theId
        {
            get
            {
                return _id;
            }
        }
        public void AddResource(IGrazing animal)
        {
            _animals.Add(animal);
        }

        public void AddResource(List<IGrazing> animals)
        {
            // TODO: implement this...
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field ID:{shortId}, has {this._animals.Count} animal(s)\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}