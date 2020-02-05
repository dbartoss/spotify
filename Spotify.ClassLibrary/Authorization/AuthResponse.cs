using Newtonsoft.Json;

namespace Spotify.ClassLibrary
{
    public class AuthResponse
    {
        public bool Success { get; private set; }
        public string AccessToken { get; private set; }
        public string RefreshToken { get; private set; }

        public AuthResponse() { }

        [JsonConstructor]
        public AuthResponse(bool success, string access_token, string refresh_token)
        {
            Success = success;
            AccessToken = access_token;
            RefreshToken = refresh_token;
        }
    }
}
