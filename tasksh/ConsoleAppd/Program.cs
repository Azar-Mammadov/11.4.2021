using ConsoleAppd.NewFolder;
using System;

namespace ConsoleAppd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci ededi daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Emeliyyat novunu secin ( + , - , * , / )");
            string isare = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ikinci ededi daxil edin");
            int b = Convert.ToInt32(Console.ReadLine());
            ClassLibrary cla = new ClassLibrary();
            Console.WriteLine("Netice");
            Console.WriteLine(cla.cxs( a, b, isare));
            
        }
    }
}
