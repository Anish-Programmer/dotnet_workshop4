namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating two objects of Student class
            Student student1 = new Student();
            Student student2 = new Student();


            // giving value to instance fields
            // student1 object
            student1.studentId = 1;
            student1.name = "Ram";
            student1.age = 20;

            // student2 object
            student2.studentId = 2;
            student2.name = "Shyam";
            student2.age = 22;


            // giving value to static field using class name
            Student.address = "Kathmandu, Nepal";


            // displaying the fields of both objects and print the static field
            Console.WriteLine("Student 1: ");
            Console.WriteLine("ID: " + student1.studentId);
            Console.WriteLine("Name: "+ student1.name);
            Console.WriteLine("Age: " + student1.age);
                
            Console.WriteLine();

            Console.WriteLine("Student 2: ");
            Console.WriteLine("ID: " + student2.studentId);
            Console.WriteLine("Name: "+ student2.name);
            Console.WriteLine("Age: "+ student2.age);

            Console.WriteLine();

            Console.WriteLine("Printing static filed: ");
            Console.WriteLine("Address: " + Student.address);

        }
    }
}
