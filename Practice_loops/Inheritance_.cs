using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_loops
{
    public class Inheritance_
    {
        //Console.WriteLine("nothing");

    }

    public class A
    {
        public  virtual void method_A()
        {
            Console.WriteLine("Inside A");
        }


    }

    public class B : A
    {
        public new void method_A()
        {
            Console.WriteLine("Inside B");
        }
    }
}
