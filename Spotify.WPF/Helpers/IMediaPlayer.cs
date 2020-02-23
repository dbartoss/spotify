using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.WPF.Helpers
{
    internal interface IMediaPlayer
    {
        #region Public Methods

        void ChangeVolume(double volume);

        void TogglePlay();

        #endregion Public Methods
    }
}