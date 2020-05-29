using System;

namespace exercise11
{
    class Song
    {
        public string title;
        public string artist;
        public int billboard;

        public Song(string aTitle, string aArtist, int aBillboard)
        {
            title = aTitle;
            artist = aArtist;
            billboard = aBillboard;
        }
    }
}