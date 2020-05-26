using System;
namespace exercise9{
    class Book
    {
         public string title;
         public string author;
         public int rating;
         public Book(string aTitle, string anAuthor, int aRating)
         {
             Console.WriteLine("Creat a new book ");
             title = aTitle;
             author = anAuthor;
             rating = aRating;
         }
    }
}