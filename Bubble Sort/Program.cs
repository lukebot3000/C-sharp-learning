using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("             Random Number Sorting:\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("             Initial List:\n\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Random Rand = new Random();
            List<int> RandBubbleList = new List<int>();
            Console.ReadLine();
            for (int i = 0;i<100;i++)
            {
                int temp = Rand.Next(0,1000);
                RandBubbleList.Add(temp);
                Console.WriteLine($"{temp}");
            }
            Console.ReadLine();
            bool swapped = true;
            while (swapped == true)
            {
                for (int i = 0; i < RandBubbleList.Count-1; i++)
                {
                    if (RandBubbleList[i] < RandBubbleList[i+1])
                    {
                        int temp = RandBubbleList[i];
                        RandBubbleList.RemoveAt(i);
                        RandBubbleList.Insert(i + 1, temp);
                        swapped = true;

                    }
                }

            }
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("             Sorted List:\n\n\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i=0; i<RandBubbleList.Count;i++)
            {
                Console.WriteLine($"{RandBubbleList[i]}");
            }
            Console.ReadLine();
        }
    }
}
