using System;

namespace Spotify.ClassLibrary
{

    public sealed class Authorization
    {
        private static readonly Lazy<Authorization> lazy = new Lazy<Authorization>(() => new Authorization());
        private Authorization() { }

        public static Authorization Instance { get => lazy.Value; }
        public AuthCredentials AuthCredentials { get; private set; }

        public void SetCredentials(AuthResponse response)
        {
            AuthCredentials = new AuthCredentials(response);
        }
    }
}
