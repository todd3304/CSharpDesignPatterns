using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using AbstractFactory;
using Builder;
using Singleton;
using Adapter;
using Decorator;
using Facade;
using Iterator;
using Observer;
using Visitor;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractFactoryDemo();

            //BuilderPatternDemo();            

            SingletonPatternDemo();

            //AdapterPatternDemo();

            //DecoratorPatternDemo();

            //FacadePatternDemo();

            //IteratorPatternDemo();

            //IteratorPatternDemo2();

            //ObserverPatternDemo();

            //VisitorPatternDemo();
        }

        private static void VisitorPatternDemo()
        {
            IWheel wheel = new NarrowWheel(24);
            wheel.AcceptVisitor(new WheelDiagnostics());
            wheel.AcceptVisitor(new WheelInventory());
        }

        private static void ObserverPatternDemo()
        {
            Speedometer mySpeedometer = new Speedometer();
            SpeedMonitor monitor = new SpeedMonitor(mySpeedometer);
            Gearbox gearbox = new Gearbox(mySpeedometer);

            mySpeedometer.CurrentSpeed = 10;
            mySpeedometer.CurrentSpeed = 20;
            mySpeedometer.CurrentSpeed = 25;
            mySpeedometer.CurrentSpeed = 30;
            mySpeedometer.CurrentSpeed = 35;
        }

        private static void InteratorPatternDemo2()
        {
            Console.WriteLine("=== road bikes ===");
            RoadBikeRange roadRange = new RoadBikeRange();
            foreach (IBicycle bicycle in roadRange.Range)
            {
                Console.WriteLine(bicycle);
            }

            Console.WriteLine("=== mountain bikes ===");
            MountainBikeRange mountainRange = new MountainBikeRange();
            foreach (IBicycle bicycle in mountainRange.Range)
            {
                Console.WriteLine(bicycle);
            }

        }

        private static void IteratorPatternDemo()
        {
            Console.WriteLine("=== road bikes ===");
            RoadBikeRange roadRange = new RoadBikeRange();
            PrintIterator(roadRange.GetEnumerator());


            Console.WriteLine("=== mountain bikes ===");
            MountainBikeRange mountainRange = new MountainBikeRange();
            PrintIterator(mountainRange.GetEnumerator());
        }

        private static void PrintIterator(IEnumerator iter)
        {
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }

        }

        private static void FacadePatternDemo()
        {
            BikeFacade facade = new BikeFacade();

            facade.PrepareForSale(new Downhill(BikeColor.red, new WideWheel(20)));
        }

        private static void DecoratorPatternDemo()
        {
            IBicycle myTourBike = new Touring(new NarrowWheel(24));

            Console.WriteLine(myTourBike);

            myTourBike = new CustomGripOption(myTourBike);

            Console.WriteLine(myTourBike);

            myTourBike = new LeatherSeatOption(myTourBike);

            Console.WriteLine(myTourBike);
        }

        private static void AdapterPatternDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();

            wheels.Add(new NarrowWheel(24));
            wheels.Add(new WideWheel(20));
            wheels.Add(new NarrowWheel(26));
            wheels.Add(new UltraWheelAdapter(new UltraWheel(28)));

            foreach (IWheel wheel in wheels)
            {
                Console.WriteLine(wheel);
            }
        }

        private static void SingletonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("next serial " + generator.NextSerial);
            Console.WriteLine("next serial " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial " + generator.NextSerial);
        }

        private static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike = new Downhill(BikeColor.green, new WideWheel(24));

            BikeBuilder builder = new MountainBikeBuilder(mountainBike);

            BikeDirector director = new MountainBikeDirector();

            IBicycle bicycle = director.Build(builder);

            Console.WriteLine(bicycle);
        }

        private static void AbstractFactoryDemo()
        {
            /*
            parent class object instance is created by its child class. this parent class can only see method that it created, that its child uses.
            any child types created, cannot be seen unless it was first created by the parent.
            */
            AbstractBikeFactory factory = new RoadBikeFactory();

            /*
            create bike parts
            Interface object is created. The factory objects created above calls the method that returns the interface that it is assigned to. These create methods create
            a new object of a Frame or Seat. This object can be of either road or mountain. In this case the roadframe and roadseat.
            */
            IBikeFrame bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();

            //show what we created
            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }

        
    }
}
