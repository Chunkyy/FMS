using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.BL
{
    class FilmRepository
    {
        public Film Retrieve(int filmId)
        {
            return new Film();
        }

        public List<Film> Retrieve()
        {
            return new List<Film>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
