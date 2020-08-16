using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDIContainerTest
{
    public class MapToAttribute : Attribute
    {
        public Type ServiceType { get; }
        public Lifetime Lifetime { get; }
        public MapToAttribute(Type serviceType,Lifetime lifetime)
        {
            ServiceType = serviceType;
            Lifetime = lifetime;
        }
    }
}
