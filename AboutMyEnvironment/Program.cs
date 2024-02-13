using System.Runtime.InteropServices;

namespace AboutMyEnvironment;

class Program
{
    static void Main(string[] args)
    {
     
        
        Console.WriteLine($"CurrentDirectory: {Environment.CurrentDirectory}");
        Console.WriteLine($"VersionString: {Environment.OSVersion.VersionString}");
        Console.WriteLine($"Namespace: {typeof(Program).Namespace}" );
        
        Console.WriteLine(format: "Value is {0}.", arg0: 19.8);
        

    }
}