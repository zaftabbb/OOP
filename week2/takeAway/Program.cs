using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takeAway
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lily's age: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 1 || age > 77)
            {
                Console.WriteLine("Age should be in range 1-77");
            }

            Console.Write("Price of washing machine: ");
            float price = float.Parse(Console.ReadLine());
            if (price > 10000)
            {
                Console.WriteLine("Price of washing machine should be in range 1.00-10000.00");
            }

            Console.Write("Unit price of each toy: ");
            int unitPrice = int.Parse(Console.ReadLine());
            if (unitPrice > 40)
            {
                Console.WriteLine("Unit price of toy should be in range 1-40");
            }

            int toysCount = 0;
            double totalMoney = 0;
            int moneyGift = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyGift += 10;
                    totalMoney += moneyGift - 1;
                }
                else
                {
                    toysCount++;
                }
            }
            totalMoney += toysCount * unitPrice;

            if (totalMoney >= price)
            {
                Console.WriteLine("Yes! " + (totalMoney - price));
            }
            else
            {
                Console.WriteLine("No! " + (price - totalMoney));
            }

        }
    }
}

