using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsAndQs
{
    internal class Mixed5
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            A a2 = new C();
            string q = "";

            q += b.m1();
            q += c.m2();
            q += a.m3();

            Console.WriteLine(q);

            q = "";

            q += c.m1();
            q += c.m2();
            q += c.m3();

            Console.WriteLine(q);

            q = "";

            q += a.m1();
            q += b.m2();
            q += c.m3();

            Console.WriteLine(q);

            q = "";

            q += a2.m1();
            q += a2.m2();
            q += a2.m3();

            Console.WriteLine(q);


        }
    }
    
}
