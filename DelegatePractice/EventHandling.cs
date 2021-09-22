using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatePractice
{
    public delegate void EventHandler(string x);
    class EventHandling
    {
        public class Operation
        {
            public event EventHandler xEvent;

            public void Action(string s)
            {
                if(xEvent != null)
                {
                    xEvent(s);
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("Not register");
                }
            }
        }

        public static void CatchEvent(string s)
        {
            Console.WriteLine("Calling Event");
        }
        public static void ImplementEvent()
        {
            Operation o = new Operation();
            o.Action("Event Calling");

            Console.WriteLine();
            o.xEvent += new EventHandler(CatchEvent);
            o.Action("Event Called");
        }


    }
}
