using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TestA.Ans
{
    internal class Day
    {
        public static void Database(int x)
        {
            int i = x + 2000;
               x= i;
            Console.WriteLine(x);





        }
        public static void DatabaseA( int x )
        {

            int i = x + 2000;
            x = i;
            Console.WriteLine(x);
            Console.WriteLine();



        }
        public static void TestOne()
        {
            int v1 = 1000;
            Console.WriteLine($"v1:{v1}");
            Database(v1);
            Console.WriteLine($"v1:{v1}");
            DatabaseA(v1);
            Console.WriteLine($"v1:{v1}");
        }




    }
}
