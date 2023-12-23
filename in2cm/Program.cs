class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter inches: ");
        string inches = Console.ReadLine();
        double dInches = double.Parse(inches);
        double cm = 2.54*dInches;
        Console.WriteLine($"{inches} inches is {cm} centimeters");
    }
}