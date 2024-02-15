using SteganLib.Console.Parser;

public class Program
{
    public static void Main(string[] args)
    {
        // Test case
        string[] args2 = [
            "enSteg",
            "--m",
            "Hello there",
            "--safe",
            "--i",
            "D:\\FBDATA",
        ];

        var parser = new CommandLineParser(args2);

        Console.WriteLine(parser.SafeMode);
        Console.WriteLine(parser.Password);
        Console.WriteLine(parser.Operation);
        Console.WriteLine(parser.Image);
    }
}