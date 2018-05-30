using System;
using System.Collections.Generic;
using System.Text;

namespace FMS.BL
{
    class Genre
    {
        public int GenreId { get; private set; }
        public string GenreDescr { get; set; }

        public bool Validate()
        {
            var isValid = true;

            return isValid;
        }        
    }
}
