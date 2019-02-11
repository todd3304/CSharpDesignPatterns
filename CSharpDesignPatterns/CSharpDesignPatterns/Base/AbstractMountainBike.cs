﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    public abstract class AbstractMountainBike : AbstractBike
    {
        public AbstractMountainBike(IWheel wheel) : this(BikeColor.chrome, wheel)
        {

        }

        public AbstractMountainBike(BikeColor color, IWheel wheel) : base(color, wheel)
        {

        }
    }
}
