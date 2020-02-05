using System;
using Newtonsoft.Json;

namespace Spotify.ClassLibrary.Authorization
{

    public sealed class Authorization
    {
        private AuthData _AuthData = new AuthData();

        private Authorization() { }

        public static Authorization Instance { get => lazy.Value; }

        public AuthData AuthData { get => _AuthData; set => _AuthData = value; }

        private static readonly Lazy<Authorization> lazy = new Lazy<Authorization>(() => new Authorization());


        public void SetDataAsTokens(string data)
        {
            AuthResponse response = JsonConvert.DeserializeObject<AuthResponse>(data);
            _AuthData.AccessToken = response.AccessToken;
            _AuthData.RefreshToken = response.RefreshToken;
        }
    }
}
