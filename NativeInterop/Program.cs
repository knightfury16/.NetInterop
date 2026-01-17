using System.Runtime.InteropServices;

namespace NativeInterop;

class Program
{
    [DllImport("libmyfunc")]
    public static extern int AddTwoNumb(int a, int b);

    [DllImport("libmyfunc")]
    public static extern void Greet(string name, int age);

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine($"heelo {AddTwoNumb(5, 4)}");
        Greet("cool", 28);

    }
}
