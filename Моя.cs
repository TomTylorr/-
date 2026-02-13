using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hello;

public class MyProgram
{
    public static void Main(string[] args)
    {
        short a = 20000, b = 20000;
        int c = Add(a, b);
        Console.WriteLine("с = {0}", c);
        Console.ReadLine();
    }

    public static int Add(int a, int b)
    {
        return a + b; 
    }
}



