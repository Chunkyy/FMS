using System;
using FMS.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FMS.BLTest
{
    [TestClass]
    public class FilmTest
    {
        [TestMethod]
        public void FilmNameValid()
        {
            Film film = new Film();

            film.FilmName = "Ted";

            bool expected = true;

            bool actual = film.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilmNameMissing()
        {
            Film film = new Film();

            bool expected = false;

            bool actual = film.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilmDetailsValid()
        {
            Film film = new Film();
            film.FilmName = "Ted";
            film.ReleaseYear = 2009;

            string expected = "Ted (2009)";

            string actual = film.FilmDetails;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FilmDetailsMissingYear()
        {
            Film film = new Film();
            film.FilmName = "Ted";

            string expected = "Ted";

            string actual = film.FilmDetails;

            Assert.AreEqual(expected, actual);
        }
    }
}
