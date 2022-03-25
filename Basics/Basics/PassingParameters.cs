using System;

namespace Basics
{
    class PassingParameters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int valuetoSend = 10;
            PassbyValue(valuetoSend);
            Console.WriteLine($"Vaule is not retained {valuetoSend}");

            PassbyReferenceRef(ref valuetoSend);
            Console.WriteLine($"Vaule is not retained {valuetoSend}");

            PassbyReferenceOut(out int uninitialized);
            Console.WriteLine($"Vaule is not retained {uninitialized}");


            PassbyReferenceIn(in valuetoSend);
            Console.WriteLine($"Vaule is not retained {valuetoSend}");


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
