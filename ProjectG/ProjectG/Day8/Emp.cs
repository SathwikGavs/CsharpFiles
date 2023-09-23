using System.Collections;

namespace ProjectG.Day8
{
    internal class Emp
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public int Salary { get; private set; }

        public static void EmpHTDemo()
        {
            Hashtable empTable = new Hashtable();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empTable.Add(e.ID, e);
            }
            Console.WriteLine("Count " + empTable.Count);
            Console.WriteLine("ContainsKey(5) " + empTable.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empTable.ContainsKey(15));
        }

        public static void EmpDictionaryDemo()
        {
            Dictionary<int, Emp> empMap = new Dictionary<int, Emp>();
            for (int i = 1; i <= 10; i++)
            {
                Emp e = new Emp()
                {
                    ID = i,
                    Name = "Emp" + i,
                    Salary = 10000 * i
                };
                empMap.Add(e.ID, e);
            }
            Emp e1 = new Emp() { ID = 12345, Name = "Venkat", Salary = 1000000 };
            empMap.Add(15, e1);
            empMap.Add(16, e1);



            Console.WriteLine("Count " + empMap.Count);
            Console.WriteLine("ContainsKey(5) " + empMap.ContainsKey(5));
            Console.WriteLine("ContainsKey(15) " + empMap.ContainsKey(15));
        }

        public static void TestSortedListOfEmp()
        {
            SortedList<int, Emp> empsortlist = new SortedList<int, Emp>();
            Random r1 = new Random();
            Emp e1 = new Emp() { ID = r1.Next(100), Name = "John", Salary = (int)(r1.NextDouble() * 5000) };
            Emp e2 = new Emp() { ID = r1.Next(100), Name = "Sam", Salary = (int)(r1.NextDouble() * 5000) };
            Emp e3 = new Emp() { ID = r1.Next(100), Name = "Ajith", Salary = (int)(r1.NextDouble() * 5000) };
            Emp e4 = new Emp() { ID = r1.Next(100), Name = "Ellango", Salary = (int)(r1.NextDouble() * 5000) };
            Emp e5 = new Emp() { ID = r1.Next(100), Name = "Basker", Salary = (int)(r1.NextDouble() * 5000) };
            if (!empsortlist.ContainsKey(e1.ID))
                empsortlist.Add(e1.ID, e1);
            if (!empsortlist.ContainsKey(e2.ID))
                empsortlist.Add(e2.ID, e2);
            if (!empsortlist.ContainsKey(e3.ID))
                empsortlist.Add(e3.ID, e3);
            if (!empsortlist.ContainsKey(e4.ID))
                empsortlist.Add(e4.ID, e4);
            if (!empsortlist.ContainsKey(e5.ID))
                empsortlist.Add(e5.ID, e5);



            Console.WriteLine("Count " + empsortlist.Count);
            Console.WriteLine(" Capacity " + empsortlist.Capacity);



            foreach (var emp in empsortlist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
            Console.WriteLine("===================");
            var orderedlist = empsortlist.OrderBy(tkey => tkey.Value.Name);
            foreach (var emp in orderedlist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
            Console.WriteLine("===================");
            var desclist = empsortlist.OrderByDescending(tkey => tkey.Value.Name);
            foreach (var emp in desclist)
            {
                Console.WriteLine(emp.Key + " : " + emp.Value.Name);
            }
        }

        public static void TestTwo()
        {

            Emp empOne = new Emp();
            empOne.ID = 1001; empOne.Name = "Sam";

            Emp empTwo = empOne; //new Emp();
            empTwo.ID = 10001; empTwo.Name = "Sam";

            Emp empThree = empTwo;//new Emp();
            empThree.ID = 10001; empThree.Name = "Sam";
            bool flag = (empOne.Equals(empTwo));
            Console.WriteLine(flag);
            flag = (empOne.Equals(empThree));
            Console.WriteLine(flag);
            Console.WriteLine(empOne.GetHashCode());
            Console.WriteLine(empTwo.GetHashCode());
            Console.WriteLine(empThree.GetHashCode());

        }

    }
}
