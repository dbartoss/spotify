using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify.ClassLibrary.Shared
{
    public class Tracks
    {
        #region Public Constructors

        public Tracks()
        {
        }

        [JsonConstructor]
        public Tracks(string href, short total)
        {
            Href = href;
            Total = total;
        }

        #endregion Public Constructors

        #region Public Properties

        public string Href { get; private set; }
        public short Total { get; private set; }

        #endregion Public Properties
    }
}