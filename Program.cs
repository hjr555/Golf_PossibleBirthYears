﻿class Program
{
    static void Main()
    {
        int x=0,y=System.DateTime.Now.Year;
        
        while(x<121)
        {
            System.Console.Write($"{y-x++}" + (x < 121 ? ", " : ""));
        }
    }
}