using System;

namespace OOP
{
  public class Student
    {
       protected  int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //public void behaviour()
        //{
        //    Console.WriteLine("Student Information:");
        //    Console.WriteLine("Student Id:{0}, Name:{1},Address:{2}",Id,Name,Address);
        //}

    }
    class StudentDetail: Student
    {
        public int Role { get; set; }

        public void drivebehaviour()
        {
            Console.WriteLine("Student Information:");
            Console.WriteLine("Student Id:{0}, Name:{1},Address:{2},Role: {3}", Id=3, Name, Address,Role);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentDetail obj =new StudentDetail();
           // obj.Id = 1;
            obj.Name = "lll";
            obj.Address = "AA";
            obj.drivebehaviour();
            Console.ReadKey();
        }
    }
}
