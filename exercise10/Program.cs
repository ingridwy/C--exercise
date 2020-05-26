using System;

namespace exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("James","chemistry", 3.2, "g");
            Student student2 = new Student("Mary","History",10,"fair");
         
            Console.WriteLine(student1.HasHonours());
            Console.WriteLine(student2.HasHonours());
            Console.WriteLine(student1.gpa);
            Console.WriteLine(student1.Comment);
        }
    }
}
