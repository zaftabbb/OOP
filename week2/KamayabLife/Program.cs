using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamayabLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pizza_pts(5, 100);
        }
        static void pizza_pts(int N, int Y)
        {
            string path = "Customers.txt";
            if(!File.Exists(path))
            {
                Console.WriteLine("File not found.");
                return;
            }
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');

                string name = parts[0];
                int totalOrders = int.Parse(parts[1]);

                int start = line.IndexOf('(');
                int end = line.IndexOf(')');

                string prices = line.Substring(start + 1, end - start - 1);
                string[] priceArray = prices.Split(',');

                int count = 0;

                foreach (string pStr in priceArray)
                {
                    int p = int.Parse(pStr.Trim());
                    if (p >= Y)
                    {
                        count++;
                    }
                }

                if (count >= N)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
