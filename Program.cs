using System;

namespace bts
{
    class Program
    {
        static void Main(string[] args)
        {
            // RunBTS();
            // RunBP();
            RunQW2S();
        }

        static void RunQW2S()
        {
            var qw2s = new QueueWithTwoStacks<int>();

            qw2s.Enqueue(1);
            qw2s.Enqueue(2);
            qw2s.Enqueue(3);
            qw2s.Enqueue(4);
            qw2s.Enqueue(5);

            Console.WriteLine(qw2s.Dequeue());
            Console.WriteLine(qw2s.Dequeue());
            Console.WriteLine(qw2s.Dequeue());
            Console.WriteLine(qw2s.Dequeue());
            Console.WriteLine(qw2s.Dequeue());
        }

        static void RunBP()
        {
            var res = BalancedParentheses.IsBalanced("{()[{({})[]()}]}([])");
            Console.WriteLine($"Is the string balanced? {res}");
        }

        static void RunBTS()
        {
            var root = new Node(50);
            root.Insert(10);
            root.Insert(20);
            root.Insert(5);
            root.Insert(8);
            root.Insert(15);

            root.PrintInOrder();
        }
    }
}
