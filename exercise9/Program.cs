using System;

namespace exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Sapien","Yuval Noah Harari", 5);
            Book book2 = new Book("Homeo Deus","Yuval Noah Harari", 3);
            Console.WriteLine(book1.title);

           /* Book book1 =new Book("A:");
            book1.title ="Sapiens";
            book1.author = "Yuval Noah Harari";
            book1.rating = 5;
            Console.WriteLine(book1.title);

            Book book2 =new Book("B:");
            book2.title ="Homo Deus";
            book2.author = "Yuval Noah Harari";
            book2.rating = 3;
            Console.WriteLine(book2.author); */
        }
    }
}
