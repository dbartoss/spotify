using Spotify.ClassLibrary.Authorization;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Spotify.ClassLibrary
{

    public class SpotifyAPI
    {
        private string URL = "http://localhost:3000";

        private AuthData _authData;

        private static readonly HttpClient client = new HttpClient();


        public SpotifyAPI()
        {
            _authData = new Authorization.AuthData();
            //Authorization auth = new Authorization.lazy;
        }

        public async Task<object> SearchArtist(string artistName) {

            var response = await client.GetAsync(URL + "/search-artist");

            Console.WriteLine(response);

            return response;

            //var responseString = await response.Content.ReadAsStringAsync();
        }
    }
}
