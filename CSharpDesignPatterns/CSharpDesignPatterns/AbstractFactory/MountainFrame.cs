﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MountainFrame : IBikeFrame
    {
        public string BikeFrameParts
        {
            get { return "Frame parts for Mountain Bike"; }
        }
    }
}
