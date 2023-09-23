using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectC.Day3
{
    internal class Boxx
    {

        public int Height;
        public int Length;
        public int Width;



        public Boxx()
        {
            Console.WriteLine("Box Object Created");
        }
        public void Open()
        {
            Console.WriteLine("Box is Open");
        }
        public void Close()
        {
            Console.WriteLine("Box is Closed");
        }

        public override string ToString()
        {
            return $"Height: {Height}, Lenght:{Length}, Width: {Width}";
        }


    }
    internal class WoodenBoxx : Boxx
    {

        public WoodenBoxx()
        {
            Console.WriteLine("Wodden Box Constructor");
        }



    }
    internal class BoxxTester
    {
        public static void TestOne()
        {

            Boxx box = new Boxx();
            box.Height = 10;
            box.Width = 5;
            box.Length = 20;
            box.Open();
            box.Close();
            box.ToString();
            String output = box.ToString();
            Console.WriteLine(output);



        }
        public static void TestTwo()
        {

            WoodenBoxx box = new WoodenBoxx();
            box.Height = 10;
            box.Width = 5;
            box.Length = 20;
            box.Open();
            box.Close();
            box.ToString();
            String output = box.ToString();
            Console.WriteLine(output);



        }
    }
}

///parent class constructor 
