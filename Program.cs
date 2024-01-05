namespace typeConversion;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string str = "true";
            bool i = Convert.ToBoolean(str);
            System.Console.WriteLine(i);
        }
        catch (System.Exception)
        {

            System.Console.WriteLine("The str could not be converted to a bool");
        }

    }
}
