using Newtonsoft.Json;
using Spotify.ClassLibrary.FeaturedPlaylists;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Spotify.ClassLibrary.Shared;

namespace Spotify.ClassLibrary
{
    public class SpotifyAPI
    {
        #region Private Fields

        private readonly Authorization authorization = Authorization.Instance;
        private readonly HttpClient client = new HttpClient();
        private readonly string URL = "http://localhost:3000";

        #endregion Private Fields

        #region Public Constructors

        public SpotifyAPI()
        {
            AuthCredentials credentials = authorization.AuthCredentials;

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //client.DefaultRequestHeaders.Add("access-token", credentials.AccessToken);
            //client.DefaultRequestHeaders.Add("refresh-token", credentials.RefreshToken);
        }

        #endregion Public Constructors

        #region Public Methods

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

        public async Task<FeaturedPlaylistsResponse> GetFeaturedPLaylists()
        {
            FeaturedPlaylistsResponse playlists = null;
            HttpResponseMessage response = await client.GetAsync(URL + "/featured-playlists");
            if (response.IsSuccessStatusCode)
            {
                playlists = JsonConvert.DeserializeObject<FeaturedPlaylistsResponse>(await response.Content.ReadAsStringAsync());
            }

            return playlists;
        }

        public async Task<User> GetSignedUserAsync()
        {
            User me = null;
            HttpResponseMessage response = await client.GetAsync(URL + "/me");
            if (response.IsSuccessStatusCode)
            {
                me = JsonConvert.DeserializeObject<User>(await response.Content.ReadAsStringAsync());
            }
            return me;
        }

        public async Task<object> SearchArtist(string artistName)
        {
            var response = await client.GetAsync(URL + "/search-artist");

            Console.WriteLine(response);

            return response;
        }

        #endregion Public Methods
    }
}