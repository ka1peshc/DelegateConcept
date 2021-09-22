using System;

namespace DelegatePractice
{
    public delegate int operation(int x, int y);
    class Program
    {
        static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            operation op = new operation(Addition);
            Console.WriteLine("addition is {0}", op(50,19));
            Console.WriteLine("***************");
            MulticastDelegate.ArrayOfDelegates.ImplementDelegate();
        }
    }
}
