
namespace FinalWork
{
    public class Array
    {
        

        public static string[] ArrayTest(int Number)
        {
            string[] Data = ["1","2"];

            if (Number == 1)
            {
                
                Data = ["“Hello”", "“2”", "“world”", "“:-)”"];
            }
            if (Number == 2) 
            {
                
                Data = ["“1234”", "“1567”", "“-2”", "“computer science”"];
            }
            if (Number == 3)
            {
                
                Data = ["“Russia”", "“Denmark”", "“Kazan”"];
            }

            return Data;
        }

        public static void Main()
        {
            Console.WriteLine("[" +String.Join(", ", ArrayTest(1)) + "]");
        }
    }
}