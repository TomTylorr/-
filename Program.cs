using Hello;
using Calculater;
using System.Text;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*{
    short a = 20000, b = 20000;
    // Вызываем Add напрямую, если он в этом же файле, или через Program.Add
    short c = checked((short)MyProgram.Add(a, b)); 
    Console.WriteLine($"c = {c}");
}
catch (OverflowException ex)
{
    Console.WriteLine("Произошло переполнение: " + ex.Message);
}*/

var t = MyProgram.tup(5, "Марк");
Console.WriteLine("{0} {1} {2} {3}", t.Item3, t.Item1, t.Item2, t.Item4);


Console.WriteLine("Введите текст:");
string[] tArr;
string text = Console.ReadLine();
tArr = text.Split(' ');
Console.WriteLine("Количество слов:");
Console.WriteLine(tArr.Length);
Console.ReadLine();

public class Calculater
{
    static double f(double x)
    {
        return 3 * Math.Pow(x, 3) - 2 * Math.Pow(x, 2);
    }

    static void Calculate(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        double a;
        double b;
        double res = 0;
        char oper;

        Console.Write("Введите первое число:")


    }
}

Console.ReadKey();