// Seeusing System;
using System.Security.Cryptography.X509Certificates;

namespace uppgift35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv två tal");
            float tal1 = float.Parse(Console.ReadLine());
            float tal2 = float.Parse(Console.ReadLine());

            Console.WriteLine("välj ett räknesätt");
            Console.WriteLine("1. addition");
            Console.WriteLine("2. subtraktion");
            Console.WriteLine("3. division");
            Console.WriteLine("4. multiplikation");
            string choice = Console.ReadLine();

            if (choice == "1")

                Console.WriteLine("additionen av dina tal = " + tal1 + "+" + tal2 + "=" + (tal1 + tal2));

            else if (choice == "2")

                Console.WriteLine("subtraktionen av dina tal = " + tal1 + "-" + tal2 + "=" + (tal1 - tal2) + " eller " + tal2 + "-" + tal1 + "=" + +(tal2 - tal1));

            else if (choice == "3")

                Console.WriteLine("diviisionen av dina tal = " + tal1 + "/" + tal2 + "=" + (tal1 / tal2) + " eller " + tal2 + "/" + tal1 + "=" + (tal2 / tal1));

            else if (choice == "4")

                Console.WriteLine("multiplikationen av dina tal = " + tal1 + "*" + tal2 + "=" + +(tal1 * tal2));

        }
    }
}
