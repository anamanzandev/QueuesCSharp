using System.Collections;

namespace QueuesCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UseMyQueue();
            //UseCSharpQueue();

            Console.ReadKey();
        }

        public static void UseMyQueue()
        {
            var queue = new MyQueue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.Write(queue.ToString());
            queue.Enqueue(40);
            Console.Write(queue.ToString());

            int dequeuedElem = queue.Dequeue();
            Console.WriteLine($"Dequeued Element: {dequeuedElem}");
            Console.Write(queue.ToString());

            dequeuedElem = queue.Dequeue();
            Console.WriteLine($"Dequeued Element: {dequeuedElem}");
            Console.Write(queue.ToString());

            int peekedElem = queue.Peek();
            Console.WriteLine($"Peeked Element: {peekedElem}");

            dequeuedElem = queue.Dequeue();
            Console.WriteLine($"Dequeued Element: {dequeuedElem}");
            Console.Write(queue.ToString());

            dequeuedElem = queue.Dequeue();
            Console.WriteLine($"Dequeued Element: {dequeuedElem}");
            Console.Write(queue.ToString());

            // SHOULD THROW EXCEPTION
            //dequeuedElem = queue.Dequeue();
            //peekedElem = queue.Peek();
        }

        public static void UseCSharpQueue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            PrintQueueValues(queue);
            queue.Enqueue(40);
            PrintQueueValues(queue);

            int dequeuedElem = queue.Dequeue();
            Console.WriteLine($"Dequeued Element: {dequeuedElem}");
            PrintQueueValues(queue);

            dequeuedElem = queue.Dequeue();
            Console.WriteLine($"Dequeued Element: {dequeuedElem}");
            PrintQueueValues(queue);

            int peekedElem = queue.Peek();
            Console.WriteLine($"Peeked Element: {peekedElem}");

            dequeuedElem = queue.Dequeue();
            Console.WriteLine($"Dequeued Element: {dequeuedElem}");
            PrintQueueValues(queue);

            dequeuedElem = queue.Dequeue();
            Console.WriteLine($"Dequeued Element: {dequeuedElem}");
            PrintQueueValues(queue);

            // SHOULD THROW EX
            //dequeuedElem = queue.Dequeue();
            //peekedElem = queue.Peek();
        }

        public static void PrintQueueValues(IEnumerable myCollection)
        {
            Console.WriteLine("Start of Queue");
            foreach (Object obj in myCollection)
                Console.Write($"{obj}->");
            Console.WriteLine("");
            Console.WriteLine("End of Queue");
            Console.WriteLine("--");
        }
    }
}