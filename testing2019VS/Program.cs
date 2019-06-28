using System;

namespace testing2019VS
{
    class Program
    {
        static void Main(string[] args)
        {

            var testing = new Print();

            testing.int1 = 5;
            testing.int2 = 3;

            testing.result = testing.int1 + testing.int2;

            var finished = testing.result;

            Console.WriteLine(finished);


        }
    }
}
