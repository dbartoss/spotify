using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify.ClassLibrary.FeaturedPlaylists
{
    public class FeaturedPlaylists
    {
        #region Public Constructors

        public FeaturedPlaylists()
        {
        }

        [JsonConstructor]
        public FeaturedPlaylists(string href, List<FeaturedPlaylistItem> items)
        {
            Href = href;
            Items = items;
        }

        #endregion Public Constructors

        #region Public Properties

        public string Href { get; private set; }
        public List<FeaturedPlaylistItem> Items { get; private set; }

        #endregion Public Properties
    }
}