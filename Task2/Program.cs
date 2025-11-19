namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating object of Calculatore class
            Calculator calculator1 = new Calculator();

            calculator1.PrintWelcome();
            int sum = calculator1.Add(5,5);
            int product = calculator1.Multiply(4); // using default value for num2

            // Displaying results
            Console.WriteLine("Sum: "+ sum);
            Console.WriteLine("Product: "+ product);
        }
    }
}
