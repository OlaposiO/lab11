using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
    class Movies
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        public Movies(string title, string genre)
        {
            Title = title;
            Genre = genre;
        }
    }
}
