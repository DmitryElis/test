using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            string zodiak;
            string prof;

            Console.WriteLine("Введите ваше имя :");
            name = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст :");
            age = Console.ReadLine();

            Console.WriteLine("Введите ваш знак зодиака :");
            zodiak = Console.ReadLine();
            
            Console.WriteLine("Введите вашу профессию ");
            prof = Console.ReadLine(); 

            Console.BackgroundColor = ConsoleColor.Green;  
            Console.ForegroundColor = ConsoleColor.Black;    
            
            Console.WriteLine("Ваше имя " + name + ".\nВам " + age + "лет.\nВаш знак зодиака " + zodiak + ".\nРаботаете по профессии " + prof + ".");

            
        }
    }
}
