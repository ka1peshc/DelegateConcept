using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatePractice
{
    class MulticastDelegate
    {
        //Working code 
        //delegate void Delop(int x, int y);
        //public static void ImplementDelegate()
        //{
        //    //delegate instantion
        //    Delop dop = Operation.Add;
        //    dop += Operation.Multiplication;
        //    dop += Operation.Subtraction;
        //    dop(3,7);
        //    Console.WriteLine("******");
        //    dop(7, 3);
        //    Console.WriteLine("******");
        //    dop(45, 8);
        //    Console.WriteLine("******");
        //}
        /// <summary>
        /// Create array of delegate object method execution according to Delop[] invocation
        /// </summary>
        public class ArrayOfDelegates
        {
            delegate void Delop(int x, int y);
            static Random rm = new Random();
           
            public static void ImplementDelegate()
            {
                Delop[] DOp =
                {
                    new Delop(Operation.Add),
                    new Delop(Operation.Subtraction),
                    new Delop(Operation.Multiplication)
                };
           
                for(int i=0; i<3; i++)
                {
                    DOp[i](rm.Next(5, 47), rm.Next(2, 89));
                    DOp[i](rm.Next(1, 50), rm.Next(50, 90));
                    DOp[i](rm.Next(100, 154), rm.Next(454,999));
                    Console.WriteLine("-----------***-----------");
                }
                Console.WriteLine();
            }

        }
        /// <summary>
        /// Main logical operation.
        /// </summary>
        protected class Operation
        {
            public static void Add(int x, int y)
            {
                Console.WriteLine("Addition of two digit {0} + {1} = {2}", x, y, (x + y));
            }
            public static void Multiplication(int x, int y)
            {
                Console.WriteLine("Multiplication of two digit {0} * {1} = {2}", x, y, (x * y));
            }
            public static void Subtraction(int x, int y)
            {
                Console.WriteLine("Subtraction of two digit {0} - {1} = {2}",x,y,(x-y));
            }
        }
    }
}
