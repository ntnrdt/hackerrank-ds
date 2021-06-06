using System;
using System.Collections.Generic;

public class QueueWithTwoStacks<T>
{
    private Stack<T> stackNewestOnTop = new Stack<T>();
    private Stack<T> stackOldestOnTop = new Stack<T>();

    public void Enqueue(T value)
    {
        stackNewestOnTop.Push(value);
    }

    public T Peek()
    {
        ShiftStacks();
        return stackOldestOnTop.Peek();
    }

    public T Dequeue()
    {
        ShiftStacks();
        return stackOldestOnTop.Pop();
    }

    private void ShiftStacks()
    {
        if (stackOldestOnTop.Count == 0)
        {
            while (stackNewestOnTop.Count != 0)
            {
                stackOldestOnTop.Push(stackNewestOnTop.Pop());
            }
        }
    }
}