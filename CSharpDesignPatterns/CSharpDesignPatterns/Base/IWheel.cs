﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace CSharpDesignPatterns
{
    public interface IWheel : IVisitable
    {
        int Size { get; }

        bool IsWide { get; }

        void AcceptVisitor(IWheelVisitor visitor);
    }
}
