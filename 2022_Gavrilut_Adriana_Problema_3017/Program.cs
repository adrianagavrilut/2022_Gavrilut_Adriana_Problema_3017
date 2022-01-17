using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_Gavrilut_Adriana_Problema_3017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti baza c = ");
            char c = char.Parse(Console.ReadLine());
            Console.Write("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 'b':
                    string result = ConvertFromBase10(n, 2);
                    Console.WriteLine(result);
                    break;
                case 'o':
                    string result1 = ConvertFromBase10(n, 8);
                    Console.WriteLine(result1);
                    break;
                case 'h':
                    string result2 = ConvertFromBase10(n, 16);
                    Console.WriteLine(result2);
                    break;
                default:
                    Console.WriteLine("Valorile corecte sunt b, o, h");
                    break;
            }
        }

        private static string ConvertFromBase10(int n, int c)
        {
            Stack<int> resturi = new Stack<int>();
            while (n > 0)
            {
                resturi.Push(n % c);
                n /= c;
            }
            StringBuilder sb = new StringBuilder();
            int c1;
            while (resturi.Count > 0)
            {
                c1 = resturi.Pop();
                if (c1 < 10)
                {
                    sb.Append((char)('0' + c1));
                }
                else
                {
                    sb.Append((char)('A' + c1 - 10));
                }
            }
            return sb.ToString();
        }
    }
}
