using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZQ
{
    internal class Zclass1
    {


        public static void Zmethod(object newint)
        {
            int[] arr = newint[] { 1, 2, 3, 4, 5 };
            fun(ref arr);
        }
        static void fun(ref int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * 5;
                Console.Write(a[i] + " ");
            }

        }
        
    }
}
