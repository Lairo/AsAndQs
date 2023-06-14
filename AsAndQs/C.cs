using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsAndQs
{
    internal class C : B
    {
        public override string m3()
        {
            return "C's m3 " + (ivar + 6);
        }
    }
}
