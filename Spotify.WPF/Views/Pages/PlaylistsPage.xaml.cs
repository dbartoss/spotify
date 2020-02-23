using Spotify.ClassLibrary.FeaturedPlaylists;
using Spotify.WPF.Views.Components;
using System.Windows.Controls;

namespace Spotify.WPF.Views.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy PlaylistsPage.xaml
    /// </summary>
    public partial class PlaylistsPage : Page
    {
        #region Public Constructors

        public PlaylistsPage(FeaturedPlaylistsResponse featuredPlaylists)
        {
            InitializeComponent();
            TitleBlock.Text = featuredPlaylists.Message;

            featuredPlaylists.Playlists.Items.ForEach(playlist =>
            {
                var playlistCard = new PlaylistCardComponent(playlist.Name, playlist.Images[0].Url, playlist.Uri);
                Frame frame = new Frame();
                frame.Navigate(playlistCard);
                Playlists.Children.Add(frame);
            });
        }

        #endregion Public Constructors
    }
}