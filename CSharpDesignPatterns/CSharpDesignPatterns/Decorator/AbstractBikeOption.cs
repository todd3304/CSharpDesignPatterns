﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Decorator
{
    public abstract class AbstractBikeOption : AbstractBike
    {
        protected internal IBicycle decoratedBike;

        public AbstractBikeOption(IBicycle bicycle)
            : base(BikeColor.chrome, bicycle.GetWheel)
        {
            this.decoratedBike = bicycle;
        }
    }
}
