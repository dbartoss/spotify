namespace Spotify.ClassLibrary
{
    public class AuthCredentials
    {
        #region Public Constructors

        public AuthCredentials()
        {
        }

        public AuthCredentials(AuthResponse credentials)
        {
            AccessToken = credentials.AccessToken;
            RefreshToken = credentials.RefreshToken;
        }

        #endregion Public Constructors

        #region Public Properties

        public string AccessToken { get; private set; }
        public string RefreshToken { get; private set; }

        #endregion Public Properties
    }
}