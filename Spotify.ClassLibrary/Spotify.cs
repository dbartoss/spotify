using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Spotify.ClassLibrary
{

    public class SpotifyAPI
    {
        private readonly string URL = "http://localhost:3000";

        private readonly HttpClient client = new HttpClient();
        private readonly Authorization authorization = Authorization.Instance;


        public SpotifyAPI()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            AuthCredentials credentials = authorization.AuthCredentials;
        }

        public async Task<AuthResponse> GetAuthCredentials(string url)
        {
            AuthResponse authResponse = null;
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                authResponse = JsonConvert.DeserializeObject<AuthResponse>(await response.Content.ReadAsStringAsync());
            }
            return authResponse;
        }

        public async Task<object> SearchArtist(string artistName) {

            var response = await client.GetAsync(URL + "/search-artist");

            Console.WriteLine(response);

            return response;

            //var responseString = await response.Content.ReadAsStringAsync();
        }
    }
}
