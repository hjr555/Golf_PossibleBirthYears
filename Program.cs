using System;

public class Program
{
    public static void Main(string[] args)
    {
        var y = DateTime.Now.Year;
        var x = y - 120;

        for(; y >= x; y--)
        {
            Console.Write($"{y}");
            if(y != x) Console.Write(", ");
        }
    }
}
