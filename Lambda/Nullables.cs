using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    class Nullables
    {
        public static void nullables()
        {
            int? num = null;

            Console.WriteLine("Nullable int is {0}", num);

            double? pi = null;

            Console.WriteLine("Value of PI is {0}", pi ?? Math.PI);

        }
    }
}
