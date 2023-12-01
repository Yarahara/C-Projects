using System.Globalization;

namespace numberPattern3
{
    public static class Program
    {
        static void Main(string[] args)
        {
           for(int i = 0; i<10; i++)
           {
            for(int j = 0; j <=10-i; j++)
            {
                Console.Write(" ");
            }
            for(int k=0; k < i+1; k++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
           } 
           Console.ReadKey();
        }
        
    }
}