using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.Day1
{
    internal class Statements
    {


        public static void TestOne()
        {

            Console.WriteLine("ENTER YOUR AGE");
            String ageString = Console.ReadLine();
            int age = int.Parse(ageString);



            if (age < 10)
            {

                Console.WriteLine("SORRY YOU CAN'T DRIVE");


            }
            else
            {

                Console.WriteLine("YOU CAN DRIVE");

            }







        }
        public static bool isNumeric(String pValue)
        {

            bool result = false;
            if (pValue == null)
            {

                Console.WriteLine("INVALID String!!");
                return false;

            }
            char[] data = pValue.ToCharArray();
            int length = data.Length;
            for (int i = 0; i < length; i++)
            {
                char c1 = data[i];
                int ascii = (int)c1;
                if (ascii < 48 || ascii > 57)
                {
                    Console.WriteLine("Value is not a NUMBER!!!");
                    return false;



                }





            }


            result = true;
            return result;


        }
    }
}
