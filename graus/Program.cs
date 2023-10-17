using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propriedade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------conversor de graus para fahrenheit----------");
            Console.WriteLine("Qual a temperatura em graus?");
            float graus = int.Parse(Console.ReadLine());
            float fahrenheit = (9f * graus + 160f) / 5f;
            Console.WriteLine(fahrenheit);
            Console.ReadLine();
        }
 
    }
}
