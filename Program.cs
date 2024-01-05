namespace typeConversion;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        byte b = (byte)i; // this is explicit casting
        Console.WriteLine(b);
    }
}
