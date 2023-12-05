namespace learning
{
    class Project 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########################");
            Console.WriteLine("# Hello, CSIS Students!");
            Console.WriteLine("########################");

            string str1 = "abc";
            string str2 = "123.45";
            Console.WriteLine(str1,str2);

            Console.WriteLine("Enter a number");
            float num = float.Parse(Console.ReadLine());
            Console.WriteLine(num);

            int a = 2;
            int b = 19;
            string c = a.ToString() + "." + b.ToString();
            Console.WriteLine(c.GetType());
            Console.WriteLine(c);

            double num2 = 678.9;

            int d = 180/(b-1);
            Console.WriteLine(d);

            Console.WriteLine("Enter oz: ");
            double oz = double.Parse(Console.ReadLine());
            double ml = oz * 29.5735;
            Console.WriteLine($"{oz} oz is {ml} ml");

            Console.WriteLine("Enter ml: ");
            double ml2 = double.Parse(Console.ReadLine());
            double oz2 = ml / 29.5735;
            Console.WriteLine($"{oz} oz is {ml} ml");



        }
    }
}