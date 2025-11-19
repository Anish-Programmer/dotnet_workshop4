namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating an object of ParameterDemo class
            ParameterDemo obj1 = new ParameterDemo();

            // calling methods in ParameterDemo class
            int x = 5;  // initializing parameter before calling ref method
            Console.WriteLine($"Original value of x: {x} ");
            obj1.Increase(ref x);  // callling ref method Increase()
            Console.WriteLine($"Increased value of x by 10: {x} ");

            
            string fullName; // declaring out parameter
            obj1.GetFullName(out fullName);  // calling out method GetFullName()
            Console.WriteLine("Full Name: " + fullName);

            
            int result = obj1.SumAll(10,20,30,40,50); // passing multiple arguments to params method SumAll()
            Console.WriteLine("Sum of all numbers: " + result);
        }
    }
}
