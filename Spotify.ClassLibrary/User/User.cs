using Newtonsoft.Json;
using Spotify.ClassLibrary.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify.ClassLibrary.Shared
{
    public class User
    {
        #region Public Constructors

        public User()
        {
        }

        [JsonConstructor]
        public User(string country, string display_name, string href, string id, string type, List<Image> images)
        {
            Country = country;
            DisplayName = display_name;
            Href = href;
            Id = id;
            Type = type;
            Images = images;
        }

        #endregion Public Constructors

        #region Public Properties

        public string Country { get; private set; }
        public string DisplayName { get; private set; }
        public string Href { get; private set; }
        public string Id { get; private set; }
        public List<Image> Images { get; private set; }
        public string Type { get; private set; }

        #endregion Public Properties
    }
}