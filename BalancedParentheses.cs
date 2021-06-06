using System;
using System.Collections;

public static class BalancedParentheses
{
    public static char[][] TOKENS = new char[][] { new[] { '{', '}' }, new[] { '[', ']' }, new[] { '(', ')' } };

    public static bool IsBalanced(string expression)
    {
        var stack = new Stack();

        for (var i = 0; i < expression.Length; i++)
        {
            char c = expression[i];

            if (IsOpenTerm(c))
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0 || !Matches((char)stack.Pop(), c))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    public static bool IsOpenTerm(char c)
    {
        foreach (var array in TOKENS)
        {
            if (array[0] == c)
                return true;
        }

        return false;
    }

    public static bool Matches(char openTerm, char closeTerm)
    {
        foreach (var array in TOKENS)
        {
            if (array[0] == openTerm)
                return array[1] == closeTerm;
        }

        return false;
    }
}