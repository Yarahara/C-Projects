using System.Globalization;

namespace listDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>
            {
                12, 10, 32, 3, 66, 17, 42, 99, 20
            };

            foreach (int num in nums)
            {
                Console.WriteLine($"{num} {num*num}");
            }
        }
    }
}