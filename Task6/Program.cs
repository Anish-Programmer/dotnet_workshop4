namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // asking user to input marks
            Console.Write("Enter marks: ");
            bool isMarksValid = int.TryParse(Console.ReadLine(), out int marks);  // using int.TryParse to validate input

            // asking user to enter total
            Console.Write("Enter total: ");
            bool isTotalValid = int.TryParse(Console.ReadLine(), out int total); // using int.TryParse to validate input

            // checking if both inputs are valid integers
            if (!isMarksValid || !isTotalValid)
            {
                Console.WriteLine("Invalid input! Required integers.");
                return; // exit the program if input is invalid
            }

            // calulating percentage
            double percentage = marks / total * 100;

            // printing the percentage
            Console.WriteLine($"Percentage is {percentage}");



            /*1.Why is the output incorrect?
             *Ans; The output is incorrect i.e. percentage is 0, because integer division is performed when calculating the percentage ( marks / total * 100).
             *     As both marks and total are integers.
             *
             *2. How can we correct the program?
             *Ans: We can correct the program by ensuring that the division is performed using floating-point arithmetic. 
             *     This can be achieved by casting either marks or total to double before performing the division.
             */

        }
    }
}
