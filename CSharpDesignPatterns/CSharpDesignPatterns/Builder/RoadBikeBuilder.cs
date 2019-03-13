using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Builder
{
    public class RoadBikeBuilder : BikeBuilder
    {
        private AbstractRoadBike _roadBikeInProgress;

        public override IBicycle Bicycle
        {
            get
            {
                return _roadBikeInProgress;
            }
        }

        public RoadBikeBuilder(AbstractRoadBike roadBike)
        {
            this._roadBikeInProgress = roadBike;
        }

        public override void BuildStreetTires()
        {
            Console.WriteLine("building roadbike street tires");
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("building roadbike handle bars");
        }
    }
}
