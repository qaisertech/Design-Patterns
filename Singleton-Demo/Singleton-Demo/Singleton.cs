using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Demo
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton SingletonObject = null;
        public static Singleton GetSingletonObject
        {
            get
            {
                if (SingletonObject == null)
                    SingletonObject = new Singleton();
                return SingletonObject;

            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter: " + counter);
        }
        public void PrintDetails(string details)
        {
            Console.WriteLine(details);
        }
    }
}
