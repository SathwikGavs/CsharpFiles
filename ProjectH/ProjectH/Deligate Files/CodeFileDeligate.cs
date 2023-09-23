





public delegate void MethodHandlerA();
public delegate void MethodHandlerB(int x, int y);



public class MathCalculater
{
    public void DoTask()
    {
        Console.WriteLine("Calculater DoTask");
    }
    public int Add(int x, int y)
    {
        Console.WriteLine(x + "," + y);
        return x + y;
    }
    public int Multiply(int x, int y)
    {
        Console.WriteLine(x + "," + y);
        return x * y;
    }
    public int Divide(int x, int y)
    {
        Console.WriteLine(x + "," + y);
        return x / y;
    }

    public class Delegatedemo
    {
        public static void TestOne()
        {
            MathCalculater mc = new MathCalculater();
            MethodHandlerA methodHandlerA = mc.DoTask;
            MethodHandlerB methodHandlerB = mc.Add;
            MethodHandlerB methodHandlerTwo = mc.Multiply;
            // MethodHandlerB methodHandlerThree = new MethodHandlerB(mc.Divide);   // Illegal
            methodHandlerA();
            int addResult = methodHandlerB(100, 50);
            Console.WriteLine(addResult);
            int multiplyResult = methodHandlerTwo(20, 5);
            Console.WriteLine(multiplyResult);
        }
    }

    //All events are multicast Deligates //