using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Demo
{
    public class Student
    {
        public void FromStudent()
        {
            Singleton singleton= Singleton.GetSingletonObject;
            singleton.PrintDetails("Call for Students");
        }
    }
}
