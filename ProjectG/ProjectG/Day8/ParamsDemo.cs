using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectG.Day8
{
    internal class ParamsDemo
    {

        //params - variable length argument
        public static void AddIntParameters(params int[] arguments)
        {
            int add = 0;
            Console.WriteLine("Param Length " + arguments.Length);
            foreach (int argu in arguments)
            {
                add += argu;
            }
            Console.WriteLine(add);
        }
        static void TestAddIntParams()
        {
            AddIntParameters(1);
            AddIntParameters(1, 2, 3, 4, 5);
        }

    }
}
