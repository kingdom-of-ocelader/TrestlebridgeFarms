using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Goat : IResource, IGrazing, ICompost
    {
        private Guid _id = Guid.NewGuid();
        public double GrassPerDay { get; set; } = 4.1;
        private double _compostProduced { get; } = 7.5;
        public string Type { get; } = "Goat";
        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }
        public void Graze()
        {
            Console.WriteLine($"Goat ID:{this._shortId}, just ate {this.GrassPerDay}kg of grass");
        }

        public double Composter()
        {
            return _compostProduced;
        }

        public override string ToString()
        {
            return $"Goat ID:{this._shortId}, says Baaaa!";
        }
    }
}