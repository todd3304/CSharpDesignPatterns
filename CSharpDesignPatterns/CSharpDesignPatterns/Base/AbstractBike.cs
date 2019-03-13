using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatterns
{
    public abstract class AbstractBike : IBicycle
    {
        private BikeColor _color;
        private IWheel _wheel;


        public BikeColor ColorType
        {
            get
            {
                return _color;
            }
        }

        public IWheel GetWheel
        {
            get
            {
                return _wheel;
            }
        }

        public abstract decimal Price { get; }

        public AbstractBike(BikeColor color, IWheel wheel)
        {
            this._wheel = wheel;
            this._color = color;
        }

        public virtual void Paint(BikeColor color)
        {
            this._color = color;
        }

        public override string ToString()
        {
            return this.GetType().Name + " bicycle color is " + _color + " and costs $" + Price;
        }

        public virtual void CleanFrame()
        {
            Console.WriteLine("cleaning frame...");
        }

        public virtual void AirTires()
        {
            Console.WriteLine("airing up tires...");
        }

        public virtual void TestRide()
        {
            Console.WriteLine("taking bike for test ride...");
        }
    }
}
