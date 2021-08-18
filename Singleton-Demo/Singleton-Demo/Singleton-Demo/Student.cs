using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Demo
{
    /// <summary>
    /// Creating a student class which will use the singleton class along with employee class
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Object creation and method call from singleton class
        /// </summary>
        public void CallSingleton()
        {
            Singleton singleton= Singleton.GetSingletonObject;
            singleton.PrintDetails("Call for Students");
        }
    }
}
