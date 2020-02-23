using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spotify.ClassLibrary.Shared
{
    public class Image
    {
        #region Public Constructors

        public Image()
        {
        }

        [JsonConstructor]
        public Image(string url
          //short? height, short? witd
          )
        {
            Url = url;
            //Width = 0;
            //Height = 0;
            //if (height != null && witdh != null)
            //{
            //Width = (short)witdh;
            //Height = (short)height;
            //}
        }

        #endregion Public Constructors

        #region Public Properties

        //public short Height { get; private set; }
        public string Url { get; private set; }

        //public short Width { get; private set; }

        #endregion Public Properties
    }
}