using System;
using System.Collections.Generic;

namespace FMS.BL
{
    public class Film
    {
        public Film()
        {

        }
        public int FilmId { get; private set; }
        public string FilmName { get; set; }
        public int? ReleaseYear { get; set; }
        public bool Seen { get; set; }
        public bool Owned { get; set; }
        public int Rating { get; set; }
        public string FilmDetails
        {
            get
            {
                string filmdetails = FilmName;
                if (!string.IsNullOrWhiteSpace(ReleaseYear.ToString()))
                {
                    if (!string.IsNullOrWhiteSpace(filmdetails))
                    {
                        filmdetails += " (" + ReleaseYear.ToString() + ")";
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

            if (string.IsNullOrWhiteSpace(FilmId.ToString())) IsValid = false;
            if (string.IsNullOrWhiteSpace(FilmName)) IsValid = false;

            return IsValid;
        }
    }
}
