﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Builder
{
    public abstract class BikeDirector
    {
        public abstract IBicycle Build(BikeBuilder builder);
    }
}
