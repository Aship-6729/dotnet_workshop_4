namespace Task_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Student s1 = new Student();

            s1.student_Id = 101;
            s1.student_Name = "Alice";
            s1.student_Age = 20;

            Student s2 = new(); // another way or creating object.
            s2.student_Id = 102;
            s2.student_Name = "Bob";
            s2.student_Age = 22;

            Console.WriteLine($"Student 1 Details: \n {s1.student_Id}\n{s1.student_Name}\n{s1.student_Age}");
            Console.WriteLine($"\nStudent 1 Details: \n {s2.student_Id}\n{s2.student_Name}\n{s2.student_Age}");
            Console.WriteLine($"\nPrinting Static Field{Student.student_College}");
        }
    }
}
