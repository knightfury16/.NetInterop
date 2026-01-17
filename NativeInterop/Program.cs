using System.Runtime.InteropServices;

namespace NativeInterop;

class Program
{
    [DllImport("libmyfunc")]
    public static extern int AddTwoNumb(int a, int b);

    [DllImport("libmyfunc", EntryPoint = "Greet")]
    public static extern void SayHello(string name, int age);

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine($"heelo {AddTwoNumb(5, 4)}");
        SayHello("cool", 28);

    }
}
