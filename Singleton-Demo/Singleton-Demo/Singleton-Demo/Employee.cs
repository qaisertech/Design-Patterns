using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Demo
{
    public class Employee
    {
        public void CallSingleton()
        {
            Singleton forEmployee = Singleton.GetSingletonObject;
            forEmployee.PrintDetails("Call for employee");
        }
        
    }
}
