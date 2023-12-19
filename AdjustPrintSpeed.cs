using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

internal class Adjust
{
    internal void SlowPrint(string text, int delayMilliseconds)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delayMilliseconds);
        }
        Console.WriteLine();
    }

    public void FastPrint(string text, int delayMilliseconds)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(25);
        }
    }

    internal void Slowprint(string text, int delay)
    {
        
    }
}