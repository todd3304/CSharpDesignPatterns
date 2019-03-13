﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    public abstract class AbstractRoadBike : AbstractBike
    {
        public override decimal Price { get; } = 540.00m;

        public AbstractRoadBike(IWheel wheel) : this(BikeColor.chrome, wheel)
        {

        }

        public AbstractRoadBike(BikeColor color, IWheel wheel) : base(color,wheel)
        {

        }
    }
}
