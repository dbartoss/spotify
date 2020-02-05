namespace Spotify.ClassLibrary.Authorization
{
    public class AuthData
    {
        private string _accessToken = "";
        private string _refreshToken = "";

        public AuthData() { }
        public AuthData(string accessToken, string refreshToken)
        {
            _accessToken = accessToken;
            _refreshToken = refreshToken;
        }

        public string AccessToken { get => _accessToken; set => _accessToken = value; }
        public string RefreshToken { get => _refreshToken; set => _refreshToken = value; }
    }
}
