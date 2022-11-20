using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.MovieDB;

namespace MovieDBAPITesting.MovieDBAPI
{
    public class MovieDBAPI_Tests
    {
        [Test]
        [Category("APITests")]
        public async Task API_Test()
        {
            Services.MovieDB.MovieDBAPI movieDBAPI = new Services.MovieDB.MovieDBAPI();
            var reasonPhrase = await movieDBAPI.Get_ReasonPhrase();

            Assert.AreEqual("OK", reasonPhrase);
        }

        [Test]
        [Category("APITests")]
        public async Task ValidateGOTActor()
        {
            Services.MovieDB.MovieDBAPI movieDBAPI = new Services.MovieDB.MovieDBAPI();
            var httpResponse = movieDBAPI.Get_Body();
            
            Assert.IsNotNull(httpResponse);
        }
    }
}
