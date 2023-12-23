class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter miles: ");
        string rMiles = Console.ReadLine();
        double miles = double.Parse(rMiles);
        double km = 1.60934*miles;
        Console.WriteLine($"{miles} miles is {km} kilometers");
    }
}
