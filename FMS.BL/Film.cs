using System;
using System.Collections.Generic;

namespace FMS.BL
{
    public class Film
    {
        public Film()
        {

        }
        public int filmId { get; private set; }
        public string filmName { get; set; }
        public int releaseYear { get; set; }
        public bool seen { get; set; }
        public bool owned { get; set; }
        public int rating { get; set; }
        public string genre { get; set; }
        public string FilmDetails
        {
            get
            {
                string filmdetails = filmName;
                if (!string.IsNullOrWhiteSpace(releaseYear.ToString()))
                {
                    if (!string.IsNullOrWhiteSpace(filmdetails))
                    {
                        filmdetails += " (" + releaseYear.ToString() + ")";
                    }                    
                }
                return filmdetails;
            }
        }

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

        public bool Validate()
        {
            var IsValid = true;

            if (string.IsNullOrWhiteSpace(filmId.ToString())) IsValid = false;
            if (string.IsNullOrWhiteSpace(filmName)) IsValid = false;

            return IsValid;
        }
    }
}
