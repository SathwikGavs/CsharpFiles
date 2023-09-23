/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectE.Day4
{
    internal class Calculator
    {

        public static void NestedTryDemo()
        {
            int x = 0; int y = 0; int z = 0;
            Calculator c1 = null;
            Console.WriteLine("Before Try1");
            try
            {
                Console.WriteLine("Inside Try1");
                try
                {
                    Console.WriteLine("\tInside Nested Try");
                    Console.WriteLine("\tEnter a no");
                    x = int.Parse(Console.ReadLine());
                    Console.WriteLine("\tEnter a no");
                    y = int.Parse(Console.ReadLine());
                    c1 = new Calculator();
                    z = c1.Divide(x, y);
                }
                catch (FormatException err)
                {
                    Console.WriteLine("\tInside NestedCatch " + err.Message);
                    //throw err;//re throw
                    throw new Exception("Test msg");
                }
                finally
                {
                    Console.WriteLine("\tInside Nested  Finally");
                }
                Console.WriteLine("Inside outer Try1 After Nested Finally");
                Console.WriteLine("Result " + z);
            }
            catch (DivideByZeroException err)
            {
                Console.WriteLine("Inside outer Catch1 " + err.Message);
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine("Inside outer Catch2 " + err.Message);
            }
            catch (FormatException err)
            {
                Console.WriteLine("Inside outer Catch3 " + err.Message);
            }
            catch (Exception err)
            {
                Console.WriteLine("Inside outer Catch4 " + err.Message);
            }
            finally
            {
                Console.WriteLine("Inside outer  Finally1");
            }
            Console.WriteLine("After outer Finally1");
        }

        private int Divide(int x, int y)
        {
            throw new NotImplementedException();
        }
    }


}
*/