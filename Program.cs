﻿using System;

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
            Console.WriteLine("S = Segundo => 10s = 10 sgundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length-1, 1));
            Console.WriteLine(data);
            Console.WriteLine(type);

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