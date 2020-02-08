using Newtonsoft.Json;

namespace Spotify.ClassLibrary
{
    public class AuthResponse
    {
        #region Public Constructors

        public AuthResponse()
        {
        }

        [JsonConstructor]
        public AuthResponse(bool success, string access_token, string refresh_token)
        {
            Success = success;
            AccessToken = access_token;
            RefreshToken = refresh_token;
        }

        #endregion Public Constructors

        #region Public Properties

        public string AccessToken { get; private set; }
        public string RefreshToken { get; private set; }
        public bool Success { get; private set; }

        #endregion Public Properties
    }
}