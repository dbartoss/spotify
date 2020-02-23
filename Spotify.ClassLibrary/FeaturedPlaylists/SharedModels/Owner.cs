using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify.ClassLibrary.Shared
{
    public class Owner
    {
        #region Public Constructors

        public Owner()
        {
        }

        [JsonConstructor]
        public Owner(string display_name, object external_url, string href, string id, string type, string uri)
        {
            Id = id;
            Uri = uri;
            Href = href;
            Type = type;
            DisplayName = display_name;
            ExternalUrl = external_url;
        }

        #endregion Public Constructors

        #region Public Properties

        public string DisplayName { get; private set; }
        public object ExternalUrl { get; private set; }
        public string Href { get; private set; }
        public string Id { get; private set; }
        public string Type { get; private set; }
        public string Uri { get; private set; }

        #endregion Public Properties
    }
}