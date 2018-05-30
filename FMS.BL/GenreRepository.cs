using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FMS.BL
{
    class GenreRepository
    {

        public void RunStoredProc()
        {
            
        }

        public Genre Retrieve(int genreId)
        {
            return new Genre();
        }

        public List<Genre> Retrieve()
        {
            return new List<Genre>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
