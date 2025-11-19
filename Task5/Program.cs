namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Asking the user to input day 
             * and to determine it is a 
             * Weekday or Weekend using enum DayType
             */
            Console.Write("Enter a day (Example: Sunday): ");
            string inputDay = Console.ReadLine()!.Trim(); // Read user input and trim whitespace

            string dayLower = inputDay.ToLower(); // Convert input to lowercase for comparison

            DayType dayType; // Variable to hold the determined DayType

            /* condtion
             * Fiday and Saturday are considered Weekend
             */
            if (dayLower == "friday" || dayLower == "saturday" )
            {
                dayType = DayType.Weekend;
            }
            else
            {
                dayType = DayType.Weekday;
            }

            // printing the result
            Console.WriteLine($"It is: {dayType}\n");


            // creating an object for book and assigning values
            Book book = new Book("System Design", "Anish Tamang", 499.99);

            // creating another object for book using with expression
            Book book2 = book with
            {
                title = "Advanced System Design",
                price = 999.99
            };

            // printing the value of first book object
            Console.WriteLine("First Book Object:");
            Console.WriteLine(book);


            // deconstructing the second book object into three variables
            var (title, author, price) = book2;
            // printing the deconstructed values
            Console.WriteLine("\nDeconstructed Second Book values:");
            Console.WriteLine($"Title={title}\nAuthor={author}\nPrice={price}"); ;
        }
    }
}
