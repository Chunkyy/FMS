using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.BL
{
    class Genre
    {
        public int genreId { get; private set; }
        public string genre { get; set; }

        public Genre Retrieve(int genreId)
        {
            return new Genre();
        }

        public List<Genre> Retrieve()
        {
            return new List<Genre>();
        }
    }
}
