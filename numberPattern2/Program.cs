namespace numberPattern2
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 9; i >0; i--)
            {
                for(int j = 1; j < i+1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
    
}