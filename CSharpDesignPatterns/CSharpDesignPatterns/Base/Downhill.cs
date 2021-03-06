﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    public class Downhill : AbstractMountainBike
    {
        public override decimal Price { get; } = 870.00m;

        public Downhill(IWheel wheel) : this(BikeColor.green, wheel)
        {

        }

        public Downhill(BikeColor color, IWheel wheel) : base(color, wheel)
        {

        }
    }
}
