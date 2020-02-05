namespace Spotify.ClassLibrary
{
    public class AuthCredentials
    {
        public string AccessToken { get; private set; }
        public string RefreshToken { get; private set; }

        public AuthCredentials() {}

        public AuthCredentials(AuthResponse credentials)
        {
            AccessToken = credentials.AccessToken;
            RefreshToken = credentials.RefreshToken;
        }
    }
}
