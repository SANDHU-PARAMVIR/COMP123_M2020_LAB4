using System;

namespace COMP123_M2020_LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person param = new Person("Param", age:19);

            param.SaysHello();

            Console.ReadLine();
        }
    }
}
