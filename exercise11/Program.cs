using System;

namespace exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Song attention = new Song ("Attention","Charlie Puth",20);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(attention.getSongCount());
            Song liar = new Song("Liar", "Camila Cabello",200);
            Console.WriteLine(Song.songCount);
            Song six = new Song("Six feet under","billie Ellish", 10);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(six.getSongCount());
            Console.WriteLine(liar.title);

        }
    }
}
