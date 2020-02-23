using Newtonsoft.Json;
using Spotify.ClassLibrary.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify.ClassLibrary.FeaturedPlaylists
{
    public class FeaturedPlaylistItem
    {
        #region Public Constructors

        public FeaturedPlaylistItem()
        {
        }

        [JsonConstructor]
        public FeaturedPlaylistItem(
            bool collaborative,
            string href,
            string name,
            string snapshot_id,
            string type,
            string uri,
            ExternalUrls external_urls,
            List<Image> images,
            Tracks tracks,
            Owner owner)
        {
            Collaborative = collaborative;
            ExternalUrls = external_urls;
            Href = href;
            Images = images;
            Name = name;
            Owner = owner;
            SnapshotId = snapshot_id;
            Tracks = tracks;
            Type = type;
            Uri = uri;
        }

        #endregion Public Constructors

        #region Public Properties

        public bool Collaborative { get; private set; }
        public ExternalUrls ExternalUrls { get; private set; }
        public string Href { get; private set; }
        public List<Image> Images { get; private set; }

        public string Name { get; private set; }
        public Owner Owner { get; private set; }
        public string SnapshotId { get; private set; }
        public Tracks Tracks { get; private set; }

        public string Type { get; private set; }
        public string Uri { get; private set; }

        #endregion Public Properties
    }
}