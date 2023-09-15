using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        int n = 10000;
        string result1 = BareString(n);
        string result2 = StringBuilderMetoda(n);


        Console.WriteLine($"Ostateczny string jest taki sam: {result1 == result2}");
    }

    static string BareString(int n)
    {
        string result = "";

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 0; i < n; i++)
        {
            result += "_text_";
        }

        stopwatch.Stop();
        Console.WriteLine($"Konkatenacja surowego string zajęła: {stopwatch.Elapsed.TotalMilliseconds} ms");

        return result;
    }

    static string StringBuilderMetoda(int n)
    {
        StringBuilder resultBuilder = new StringBuilder();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        for (int i = 0; i < n; i++)
        {
            resultBuilder.Append("_text_");
        }

        stopwatch.Stop();
        Console.WriteLine($"Konkatenacja przy użyciu StringBuilder zajęła:: { stopwatch.Elapsed.TotalMilliseconds} ms");

        return resultBuilder.ToString();
    }
}
