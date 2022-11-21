using System;

namespace Virtual_And_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            drive drive = new drive();

            int rs=drive.data(2, 3);
            Console.WriteLine("Response",rs);

            drive1 drive2 = new drive1();

            int rs1 = drive2.data(2, 3);
            Console.WriteLine("Response", rs1);
        }
    }
    class Base
    {
       public virtual int data(int x,int y)//signeture part
        {
            //description can be diffrent
            return (x + y);
        }
    }
    class drive:Base
    {
        //signature must be same as base class method if want to override base class method
        //if drive class does not have any override method than it call base class method
        public override int data(int x,int y)
        {
            int re = (x * y);
            return re;
        }
    }
    class drive1 : Base
    {
        //signature must be same as base class method if want to override base class method
        //if drive class does not have any override method than it call base class method this call (runtime polymorphism) which method will be called decided in runtime
        //if drive class does  have any  method same name as it base clase methode then it call own   method
        public  int data(int x, int y)
        {
            int re = (x * y);
            return re;
        }
    }
}
