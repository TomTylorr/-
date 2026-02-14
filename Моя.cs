using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hello;

public class MyProgram
{
    public static void My(string[] args)
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

    public static Tuple<int, float, string, char> tup(int z, string name)
    {
        int x = 4 * z;
        float y = (float)(Math.Sqrt(z));
        string s = "Привет, " + name;
        char ch = (char)(name[0]);
        return Tuple.Create<int, float, string, char>(x, y, s, ch);
    }
}



