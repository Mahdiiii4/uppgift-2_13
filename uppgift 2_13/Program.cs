using System;
namespace uppgift2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket för du för lön person 1?");
            int per1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket för du för lön person 2?");
            int per2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket för du för lön person 3?");
            int per3 = int.Parse(Console.ReadLine());
            int res = (per1+per2+per3) / 3;
            Console.WriteLine("Medel värdet är" +res+ ".");
        }
    }
}