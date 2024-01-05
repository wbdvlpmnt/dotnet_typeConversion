namespace typeConversion;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string number = "1234";
            byte i = Convert.ToByte(number);
            System.Console.WriteLine(i);
        }
        catch (System.Exception)
        {

            System.Console.WriteLine("The number could not be converted to a byte");
        }

    }
}
