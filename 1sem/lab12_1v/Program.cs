using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab12_1v
{
    class Account
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;              // 1.Определение события
        public Account(int sum)
        {
            Sum = sum;
        }
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
            }
            else
            {
                Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
            }
        }
    }

    class Game
    {
        delegate 
        public static void Space()
        {
            Console.WriteLine("|\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t|");
        }

        public static void GameStart()
        {
            do
            {

            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Game.Space();



            Console.Read();
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
