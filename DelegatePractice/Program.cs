using System;

namespace DelegatePractice
{
    public delegate void DelegateEventHandler();
    class Program
    {
        //creating event method with datatype as DelegateEventHandler
        public static event DelegateEventHandler add;

        public static void India()
        {
            Console.WriteLine("India");
        }
        public static void Russia()
        {
            Console.WriteLine("Russia");
        }
        public static void Canada()
        {
            Console.WriteLine("Canada");
        }
        static void Main(string[] args)
        {
            add += new DelegateEventHandler(India);
            add += new DelegateEventHandler(Canada);
            add += new DelegateEventHandler(Russia);

            add.Invoke();

            Console.WriteLine("*********Event Handling***********");
            EventHandling.ImplementEvent();
            //MulticastDelegate.ArrayOfDelegates.ImplementDelegate();
        }
    }
}
