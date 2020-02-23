using spotify;
using Spotify.WPF.Views.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Spotify.WPF.Views.Components
{
    /// <summary>
    /// Interaction logic for PlaylistCardComponent.xaml
    /// </summary>
    public partial class PlaylistCardComponent : Page
    {
        #region Private Properties

        private string PlaylistUrl { get; set; }

        #endregion Private Properties

        #region Public Constructors

        public PlaylistCardComponent(string title, string imageUrl, string playlistUrl)
        {
            InitializeComponent();
            PlaylistTitle.Text = title;
            PlaylistImage.Source = ConvertStringToImageSource(imageUrl);
            PlaylistUrl = playlistUrl;
        }

        #endregion Public Constructors

        #region Private Methods

        private BitmapImage ConvertStringToImageSource(string url)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(url, UriKind.Absolute);
            bitmap.EndInit();
            return bitmap;
        }

        #endregion Private Methods

        private void OpenPlaylist(object sender, RoutedEventArgs e)
        {
           
        }
    }
}