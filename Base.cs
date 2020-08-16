using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDIContainerTest
{
    public class Base : IDisposable
    {
        public Base()
        {
            Console.WriteLine($"Instance of {GetType().Name} is created.");
        }
        public void Dispose() => Console.WriteLine($"Instance of {GetType().Name} is disposed.");
    }
}
