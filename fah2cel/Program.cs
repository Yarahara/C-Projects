class Program {
    public static void Main(string[] args){
        Console.WriteLine("Enter degree in fahrenheit: ");
        string fh = Console.ReadLine();
        double fh2 = double.Parse(fh);
        double cel = (5/9D)*(fh2-32);
        Console.WriteLine($"{fh} degrees fahrenheit is {cel} degrees celsius");
    }
}
