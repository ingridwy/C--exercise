using System;

namespace exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("James","chemistry", 3.2);
            Student student2 = new Student("Mary","History",2.8);
            
            Console.WriteLine(student1.HasHonours());
            Console.WriteLine(student2.HasHonours());
        }
    }
}
