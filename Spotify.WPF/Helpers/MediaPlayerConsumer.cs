using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.WPF.Helpers
{
    public class MediaPlayerConsumer : IMediaPlayer
    {
        #region Private Fields

        private MediaPlayerProvider provider;

        #endregion Private Fields

        #region Public Fields

        public bool isPlaying = false;
        public double Volume { get => provider.Volume; private set => provider.ChangeVolume(value); }

        #endregion Public Fields

        #region Public Constructors

        public MediaPlayerConsumer()
        {
            provider = new MediaPlayerProvider();
        }

        #endregion Public Constructors

        #region Public Methods

        public void ChangeVolume(double volume)
        {
            Volume = volume;
        }

        public void TogglePlay()
        {
            provider.TogglePlay();
            isPlaying = provider.isPlaying;
        }

        #endregion Public Methods
    }
}