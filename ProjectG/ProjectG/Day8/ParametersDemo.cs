﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectG.Day8
{
    internal class ParametersDemo
    {




        //by ref Parameters
        //out parameter
        public static void OutParameterMethod(int v1, out int v2)
        {
            //Console.WriteLine("v1={0},v2={1}", v1, v2); out v2 is unassigned
            v1 = v1 + 100;
            //v2 = v2 * 2000; //out v2 is unassigned
            v2 = v1 * 5; // v2 (y) is assigned
            Console.WriteLine("\t M2==> v1={0},v2={1}", v1, v2);
        }
        public static void TestOutParameter()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine("Before M2==> x={0},y={1}", x, y); // 5, 10
            OutParameterMethod(x, out y);
            //M2(v2: out x, v1: y);//Using Named Arguments
            Console.WriteLine("After M2==> x={0},y={1}", x, y);// 5, 525
        }

        public static void OptionalParameters(int v1 = 123, int v2 = 456)//optional
        {
            Console.WriteLine($"\tM3==> v1={v1},v2={v2}");
            v1 = v1 + 100;
            v2 = v2 * 2000;
            Console.WriteLine($"\tM3==> v1={v1},v2={v2}");
        }
        public static void TestOptionalParameter()
        {
            int x = 5;
            int y = 10;
            Console.WriteLine($"x={x},y={y}");
            OptionalParameters();
            OptionalParameters(x, y);
            OptionalParameters(v2: x, v1: y);//Using Named Arguments
        }


    }
}
