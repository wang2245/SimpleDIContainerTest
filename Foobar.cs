using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleDIContainerTest
{
    public class Foobar<T1, T2> : IFoobar<T1, T2>
    {
        public IFoo Foo { get; }
        public IBar Bar { get; }
        public Foobar(IFoo foo,IBar bar)
        {
            Foo = foo;
            Bar = bar;
        }
    }
}
