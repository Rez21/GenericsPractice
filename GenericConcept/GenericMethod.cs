using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConcept
{
    internal class GenericMethod
    {
        public static void toPrint<I>(I[] inputArray)
        {
            foreach(var element in inputArray)
            {
               Console.WriteLine(element);
            }
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}
