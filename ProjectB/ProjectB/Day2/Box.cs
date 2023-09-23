using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectB.Day2
{




    
    internal class Box
    {
        public int GetHeight() { return height; }
        public static int height;
        public  int width;
        public const string type = "wodden";
    }
    internal class TestBox
    {

        //public int GetHeight() { return height; }
        public  static void TestOne()
        {
            //Box.type = "glass";
            Box.height = 100;
            //Box.width = 200;
            
            Box firstBox = new Box();
            Box secondBox = new Box();

            firstBox.width = 100;
            secondBox.width = 123;
            Console.WriteLine($"firstBox={firstBox.width}");
            Console.WriteLine($"secondBox={secondBox.width}");


        }

    }
}
