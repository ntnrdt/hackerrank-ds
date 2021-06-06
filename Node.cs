using System;

public class Node
{
    public Node Left { get; set; }
    public int Value { get; set; }
    public Node Right { get; set; }

    public Node(int value)
    {
        this.Value = value;
    }

    public void Insert(int value)
    {
        if (value < this.Value)
        {
            if (this.Left == null)
                this.Left = new Node(Value);
            else
                this.Left.Insert(value);
        }
        else
        {
            if (this.Right == null)
                this.Right = new Node(value);
            else
                this.Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        if (value == this.Value)
            return true;

        if (value < this.Value)
        {
            if (this.Left == null)
                return false;
            else
                return this.Left.Contains(value);
        }
        else
        {
            if (this.Right == null)
                return false;
            else
                return this.Right.Contains(value);
        }
    }

    public void PrintInOrder()
    {
        if (this.Left != null)
            this.Left.PrintInOrder();

        Console.WriteLine(this.Value);

        if (this.Right != null)
            this.Right.PrintInOrder();
    }

    public void PrintPreOrder()
    {
        Console.WriteLine(this.Value);

        if (this.Left != null)
            this.Left.PrintPreOrder();

        if (this.Right != null)
            this.Right.PrintPreOrder();
    }

    public void PrintPostOrder()
    {
        if (this.Left != null)
            this.Left.PrintPreOrder();

        if (this.Right != null)
            this.Right.PrintPreOrder();

        Console.WriteLine(this.Value);
    }
}