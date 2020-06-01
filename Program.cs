using LessonTrainer.Model;
using System;

namespace LessonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var LinkedQueue = new LinkedQueue<int>();
            for (int i = 0; i < 10; i++)
            {
                LinkedQueue.Enqueue(i);
            }
            while (LinkedQueue.count != 0)
            {
                Console.WriteLine(LinkedQueue.Dequeue());
            }
            Console.ReadLine();
        }
    }
}
