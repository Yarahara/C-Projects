namespace listDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> numList = new List<int>
        {
            12, 10, 32, 3, 66, 17, 42, 99, 20
        };
        foreach (int num in numList)
        {
            Console.WriteLine(num );
        }
        }
        
    }
}
