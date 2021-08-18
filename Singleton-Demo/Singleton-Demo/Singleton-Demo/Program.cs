using System;

namespace Singleton_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee= new Employee();
            employee.CallSingleton();
            Student student= new Student();
            student.FromStudent();
            Console.ReadLine();
        }
    }
}
