using System;

namespace exercise11
{
    class Song
    {
        public string title;
        public string artist;
        public int billboard;
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aBillboard)
        {
            title = aTitle;
            artist = aArtist;
            billboard = aBillboard;
            songCount++;
            //songCount increase by 1 every time a new Song is created
        }
        public int getSongCount()
        {
            return songCount;
        }
    }
}