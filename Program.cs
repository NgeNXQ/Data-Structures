using System.Collections.Generic;

namespace DataStructures
{
    internal sealed class Program
    {
        static void Main(string[] args)
        {
            DataStructures.Queue<string> queue = new DataStructures.Queue<string>();
            queue.Enqueue("Denis");
            queue.Enqueue("Vlad");
            queue.Enqueue("Vadim");

            Console.WriteLine(queue.Count);

            if(queue.TryDequeue(out string result1))
                Console.WriteLine(result1);

            Console.WriteLine(queue.Count);

            if (queue.TryDequeue(out string result2))
                Console.WriteLine(result2);

            Console.WriteLine(queue.Count);

            if (queue.TryDequeue(out string result3))
                Console.WriteLine(result3);

            Console.WriteLine(queue.Count);

            if (queue.TryDequeue(out string result4))
                Console.WriteLine(result4);
            else
                Console.WriteLine("Error");

            Console.WriteLine(queue.Count);
        }
    }
}