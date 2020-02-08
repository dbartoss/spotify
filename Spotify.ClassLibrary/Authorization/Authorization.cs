using System;

namespace Spotify.ClassLibrary
{
    public sealed class Authorization
    {
        #region Private Fields

        private static readonly Lazy<Authorization> lazy = new Lazy<Authorization>(() => new Authorization());

        #endregion Private Fields

        #region Private Constructors

        private Authorization()
        {
        }

        #endregion Private Constructors

        #region Public Properties

        public static Authorization Instance { get => lazy.Value; }
        public AuthCredentials AuthCredentials { get; private set; }

        #endregion Public Properties

        #region Public Methods

        public void SetCredentials(AuthResponse response)
        {
            AuthCredentials = new AuthCredentials(response);
        }

        #endregion Public Methods
    }
}