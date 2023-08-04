using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswordGenerator passwordGenerator = new PasswordGenerator();
            while (true) { 
                Console.Write("Parol uzunluğunu daxil edin: ");
                int length = int.Parse(Console.ReadLine());

                Console.WriteLine("1) Yalniz reqemlerden ibaret");
                Console.WriteLine("2) Yalniz heriflerden ibaret");
                Console.WriteLine("3) Yuxaridakilarin her ikisi");
                Console.WriteLine("0) Cixis");
                Console.Write("Seciminiz-> ");
                string secim = Console.ReadLine();
                Console.Write("Sizin parolunuz: ");
                switch (secim) {
                    case "1": Console.WriteLine(passwordGenerator.GenerateNumericPassword(length)); break;
                    case "2": Console.WriteLine(passwordGenerator.GenerateAlphaPassword(length)); break;
                    case "3": Console.WriteLine(passwordGenerator.GenerateAlphaNumericPassword(length)); break;
                    case "0": Environment.Exit(0); break;
                    default: Console.WriteLine("Secim dogru deyil"); break;
                }
            
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
