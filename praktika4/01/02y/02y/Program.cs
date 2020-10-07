using System;

namespace _02y
{
  using System.Collections;
  class Program
  {
    static void Main(string[] args)
    {
      Queue queue = new Queue();

      queue.Enqueue("First");
      queue.Enqueue("Second");
      queue.Enqueue("Third");
      queue.Enqueue("Fourth");
      while (queue.Count > 0)
      {
        object obj = queue.Dequeue();
        Console.WriteLine("From Queue: {0}", obj);
      }

      Stack stack = new Stack();

      stack.Push("a");
      stack.Push("Second");
      stack.Push("Third");
      stack.Push("gth");
      while (stack.Count > 0)
      {
        object obj = stack.Pop();
        Console.WriteLine("'From Stack: {0}", obj);
      }
    }
}
}
