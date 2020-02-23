using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Spotify.WPF.Helpers
{
    public class MediaPlayerProvider : IMediaPlayer
    {
        #region Private Fields

        public bool isPlaying = false;
        private MediaPlayer mediaPlayer;
        public double Volume { get => mediaPlayer.Volume; private set => mediaPlayer.Volume = value; }

        #endregion Private Fields

        #region Public Constructors

        public MediaPlayerProvider()
        {
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Volume = 0.5;

            mediaPlayer.MediaFailed += (o, args) =>
             {
                 System.Windows.MessageBox.Show("Media Failed!!");
             };
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                mediaPlayer.Open(new Uri(openFileDialog.FileName));
            }
        }

        #endregion Public Constructors

        #region Public Methods

        public void ChangeVolume(double volume)
        {
            Volume = volume;
        }

        public void TogglePlay()
        {
            if (isPlaying)
            {
                mediaPlayer.Pause();
                isPlaying = false;
                return;
            }
            mediaPlayer.Play();
            isPlaying = true;
        }

        #endregion Public Methods
    }
}