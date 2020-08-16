using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDIContainerTest
{
    [AttributeUsage(AttributeTargets.Constructor)]
    public class InjectionAttribute : Attribute
    {
    }
}
