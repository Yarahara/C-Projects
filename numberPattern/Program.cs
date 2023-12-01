// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace numberPatter
{
public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j <i+1; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine(" ");
        }
    }
}
}
