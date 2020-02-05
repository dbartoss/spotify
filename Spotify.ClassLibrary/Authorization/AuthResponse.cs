using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify.ClassLibrary.Authorization
{
    public class AuthResponse
    {
        public bool Success { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public AuthResponse() { }
    }
}
