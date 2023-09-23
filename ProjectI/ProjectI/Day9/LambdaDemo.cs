//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProjectI.Day9
//{
//    internal class LambdaDemo
//    {

//        public static void DemoA()
//        {
//            Thread t = Thread.CurrentThread;
//            int id = t.ManagedThreadId;
//            Console.WriteLine("Main ID" + id);
//            ServiceA a1 = new ServiceA();
//            //a1.DoTaskA();


//            Func<int, int> foo = x => x / 2;
//            /*first int is Input Value and second int was Output value*/
//            int i = 100;
//            int result = foo(i);
//            Console.WriteLine(result);
//        }



//        public static void DemoB()
//        {
//            Func<int> foo = () => 100;
//            int result = foo();
//            Console.WriteLine(result);
//        }

//        static void DemoC()
//        {
//            Func<double, double, double> callme = (x, y) => (x + y) / 2;
//            int v1 = 101;
//            int v2 = 10;
//            double result = callme(v1, v2);
//            Console.WriteLine(result);
//        }

//        public static void DemoD()
//        {
//            Func<int, double> foo = x => x / 2;
//            int v1 = 101;
//            double result = foo(v1);
//            Console.WriteLine(result);

//        }

//        static void DemoF()
//        {
//            Func<double, int> foo = x => (int)x / 2;
//            int v1 = 101;
//            int result = foo(v1);
//            Console.WriteLine(result);


//        }
//        static void Echo(Func<String> foo)
//        {
//            string str = foo();
//            Console.WriteLine(str);
//        }

//        public static void TestEcho()
//        {
//            Echo(() => "Hello");
//            Echo(() => "World");
//        }

//        static double Dotrans(Func<int, int, double> foo)

//        {
//            return foo(50, 5);
//        }

//        public static void TestDoTrans()
//        {
//            Func<int, int, double> Multiply = (x, y) => x * y;
//            double d = Dotrans(Multiply);
//            Console.WriteLine(d);

//            Func<int, int, double> Add = (x, y) => x + y;
//            d = Dotrans(Add);
//            Console.WriteLine(d);

//            Func<int, int, double> Divide = (x, y) =>
//            {
//                if (y == 0) y = 1; return x / y;
//            };
//            double d1 = Dotrans(Divide);
//            Console.WriteLine(d1);
//        }

//        /* public static void DemoCurrenTH()
//         {
//             Thread t1 = Thread.DemoCurrentThread;
//             int id = t1.ManagedThreadId;
//             Console.WriteLine("ThreadID" + id);
//             Console.WriteLine("IsAlive" + t1.IsAlive);
//             Console.WriteLine("Priority" + t1.Priority);
//             Console.WriteLine("ThreadState" + t1.ThreadState);
//             Console.WriteLine("CurrentCulture" + t1.CurrentCulture);
//             Console.WriteLine(DateTime.Now.ToLongDateString());
//             t1.CurrentCulture = new CultureInfo("fr-FR");
//             Console.WriteLine("CurrentCulture" + t1.CurrentCulture);
//             t1.CurrentCulture = new CultureInfo("de-DE");
//             Console.WriteLine("CurrentCulture" + t1.CurrentCulture);
//             Console.WriteLine(DateTime.Now.ToLongDateString);


//         } */

//        public static void DemoG()
//        {
//            Thread t = Thread.CurrentThread;
//            int id = t.ManagedThreadId; ;
//            Console.WriteLine("Mainth ID" + id);
//            ServiceA a1 = new ServiceA();
//            Thread t1 = new Thread(a1.DoTaskA);
//            t1.Start();
//            a1.DoTask();
//            Console.WriteLine("-------End of DemoG-------");


//        }




//    }
//}
