//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProjectI.Day9
//{
//    internal class ServiceA
//    {
//        public ParameterizedThreadStart DoTaskA { get; private set; }

//        public void DoTask()
//        {
//            Thread t1 = Thread.CurrentThread;
//            int id = t1.ManagedThreadId;
//            Console.WriteLine("Inside DotaskA");
//            Console.WriteLine("\t Thread:ID");
//        }

//        //internal void DoTaskA(object? obj)
//        //{
//        //    throw new NotImplementedException();
//        //}


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
