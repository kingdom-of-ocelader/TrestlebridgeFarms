using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Duck : IResource, IDucks, IEggProducing, IFeatherProducing {

        private Guid _id = Guid.NewGuid();
        private double _EggProduced = 6;
        private double _FeatherProduced = .75;

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 5.4;
        public string Type { get; } = "Duck";

        // Methods
        public void Feed () {
            Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of grass");
        }

        public double EggCollect () {
            return _EggProduced;
        }

        public double Pluck () {
            return _FeatherProduced;
        }

        public override string ToString () {
            return $"Duck {this._shortId}. Quack!";
        }
    }
}