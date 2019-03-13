using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Visitor
{
    public class WheelDiagnostics : IWheelVisitor

    {
        public void Visit(IWheel wheel)
        {
            Console.WriteLine("diagnosing the wheels");
        }

        public void Visit(Spokes spokes)
        {
            Console.WriteLine("diagnosing the spokes");
        }

        public void Visit(Bearings bearings)
        {
            Console.WriteLine("diagnosing the bearings");
        }
    }
}
