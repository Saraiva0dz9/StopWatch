using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu() { 
            Console.Clear();
            Console.WriteLine("S = Segundo");
            Console.WriteLine("M = Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");
        }

        static void Start(int time)
        {
            
            int currenTime = 0;

            while(currenTime != time)
            {
                Console.Clear();
                currenTime++;
                Console.WriteLine(currenTime);
                Thread.Sleep(1000);
            }   
            
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
        }
    }
}