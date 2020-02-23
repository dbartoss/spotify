using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify.ClassLibrary.FeaturedPlaylists
{
    public class FeaturedPlaylistsResponse
    {
        #region Public Constructors

        public FeaturedPlaylistsResponse()
        {
        }

        [JsonConstructor]
        public FeaturedPlaylistsResponse(string message, FeaturedPlaylists playlists)
        {
            Message = message;
            Playlists = playlists;
        }

        #endregion Public Constructors

        #region Public Properties

        public string Message { get; private set; }
        public FeaturedPlaylists Playlists { get; private set; }

        #endregion Public Properties
    }

    //public class ResData
    //{
    //    public ResData()
    //    {
    //    }

    //    [JsonConstructor]
    //    public ResData()
    //}
}