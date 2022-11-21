using System;

namespace Polymorphism
{
   //Polymorphism:Greek word means have many form
   //Object can be identified by more than one type
   //Example: A dog is also consider as Canine,animal,organisn
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            Vehicle[] vehicles = { car, bicycle,boat};
            foreach (var item in vehicles)
            {
                item.Go();
                
            }

        }
    
    }
    class Vehicle
    {
        public Vehicle()
        {
            //Constractor can not be override It does not have a return type and its name is same as the class name
            //is invocked when it class object creaate its also responsible for memory allocation and initilize 
            Console.WriteLine("Cons");
        }
        public virtual  void Go()//signeture part
        {
            Console.WriteLine("Hello Base");
        }
    }
    class Car:Vehicle
    {
        //signature must be same as base class method if want to override base class method
        //if drive class does not have any override method than it call base class method

        //signature must be same as base class method if want to override base class method
        //if drive class does not have any override method than it call base class method this call (runtime polymorphism) which method will be called decided in runtime
        //if drive class does  have any  method same name as it base clase methode then it call own   method
        public override  void Go()//signeture part
        {
            Console.WriteLine("This car is moving!");
        }

    }
    class Bicycle:Vehicle
    {
        //signature must be same as base class method if want to override base class method
        //if drive class does not have any override method than it call base class method

        //signature must be same as base class method if want to override base class method
        //if drive class does not have any override method than it call base class method this call (runtime polymorphism) which method will be called decided in runtime
        //if drive class does  have any  method same name as it base clase methode then it call own   method
        public override void Go()//signeture part
        {
            Console.WriteLine("This Bicycle is moving!");
        }
    }
    class Boat:Vehicle
    {
        //signature must be same as base class method if want to override base class method
        //if drive class does not have any override method than it call base class method

        //signature must be same as base class method if want to override base class method
        //if drive class does not have any override method than it call base class method this call (runtime polymorphism) which method will be called decided in runtime
        //if drive class does  have any  method same name as it base clase methode then it call own   method
        public override void Go()//signeture part
        {
            Console.WriteLine("This Boat is moving!");
        }
    }
}
