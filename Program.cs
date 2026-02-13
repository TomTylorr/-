using Hello;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


try
{
    short a = 20000, b = 20000;
    // Вызываем Add напрямую, если он в этом же файле, или через Program.Add
    short c = checked((short)MyProgram.Add(a, b)); 
    Console.WriteLine($"c = {c}");
}
catch (OverflowException ex)
{
    Console.WriteLine("Произошло переполнение: " + ex.Message);
}