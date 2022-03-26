using System;
using System.Collections.Generic;

namespace Basics
{
    class PassingParameters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Pass values
            int valuetoSend = 10;
            PassbyValue(valuetoSend);
            Console.WriteLine($"Vaule is not retained {valuetoSend}");
            PassbyReferenceRef(ref valuetoSend);
            Console.WriteLine($"Vaule is not retained {valuetoSend}");
            PassbyReferenceOut(out int uninitialized);
            Console.WriteLine($"Vaule is not retained {uninitialized}");
            PassbyReferenceIn(in valuetoSend);
            Console.WriteLine($"Vaule is not retained {valuetoSend}");

            // Simple custom stack with Generics.
            var myStack = new MyStack<string>();
            myStack.Push("Amar");
            myStack.Push("Reddy");
            Console.WriteLine(myStack.Pop()); // Reddy
            Console.WriteLine(myStack.Pop()); // Amar
            Console.WriteLine(myStack.Pop()); // Exception

            Stack<int> myss = new Stack<int>();
            myss.Push(1);
            myss.Push(2);
            myss.Pop();
            myss.Pop();
            myss.Pop();
            Console.ReadLine();
        }

        static void PassbyValue(int a)
        {
            a = a + 10;
        }

        static void PassbyReferenceRef(ref int a)
        {
            a += 10;
        }
        static void PassbyReferenceOut(out int a)
        {
            a = 0;
            a += 100;
        }

        static void PassbyReferenceIn(in int a)
        {
            //a = 0;
            //a += 100;
        }
    }
}
