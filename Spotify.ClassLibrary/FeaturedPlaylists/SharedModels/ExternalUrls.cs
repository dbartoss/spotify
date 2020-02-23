using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify.ClassLibrary.Shared
{
    public class ExternalUrls
    {
        #region Public Constructors

        public ExternalUrls()
        {
        }

        [JsonConstructor]
        public ExternalUrls(string spotify)
        {
            Spotify = spotify;
        }

        #endregion Public Constructors

        #region Public Properties

        public string Spotify { get; private set; }

        #endregion Public Properties
    }
}