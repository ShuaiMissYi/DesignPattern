using System;

namespace StateMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Work work1 = new Work();
            work1.Hour = 16;
            work1.WriteState();


            Console.WriteLine();

        }
    }
}
