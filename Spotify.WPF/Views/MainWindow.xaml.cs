namespace spotify
{
    using Microsoft.Win32;
    using Spotify.ClassLibrary;
    using Spotify.ClassLibrary.FeaturedPlaylists;
    using Spotify.ClassLibrary.Shared;
    using Spotify.WPF.Helpers;
    using Spotify.WPF.Views.Pages;
    using System;
    using System.Media;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;

    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Fields

        private MediaPlayerConsumer _mediaPlayer;
        private SpotifyAPI _spotify;
        private bool isVolumeInit = true;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            _mediaPlayer = new MediaPlayerConsumer();

            InitializeComponent();
            _spotify = new SpotifyAPI();

            SetUserInfo();

            CurrentPage.Content = new HomePage();
        }

        #endregion Public Constructors

        #region Public Methods

        public void Navigate(Page page)
        {
            CurrentPage.Navigate(page);
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The Slider_ValueChanged
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="RoutedPropertyChangedEventArgs{double}" /></param>
        private void HandleVolumeChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            double value = slider.Value / 100;
            _mediaPlayer.ChangeVolume(value);
        }

        /// <summary>
        /// The LogOut
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="RoutedEventArgs" /></param>
        private void LogOut(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// The NavigateToHomePage
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="RoutedEventArgs" /></param>
        private void NavigateToHomePage(object sender, RoutedEventArgs e)
        {
            CurrentPage.Content = new HomePage();
        }

        /// <summary>
        /// The NavigateToPlaylistsPage
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="RoutedEventArgs" /></param>
        private async void NavigateToPlaylistsPage(object sender, RoutedEventArgs e)
        {
            FeaturedPlaylistsResponse featuredPlaylists = await _spotify.GetFeaturedPLaylists();
            CurrentPage.Content = new PlaylistsPage(featuredPlaylists);
        }

        /// <summary>
        /// The NavigateToSearchArtistsPage
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="RoutedEventArgs" /></param>
        private void NavigateToSearchArtistsPage(object sender, RoutedEventArgs e)
        {
            CurrentPage.Content = new SearchArtistsPage();
        }

        /// <summary>
        /// The OnBackward
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="RoutedEventArgs" /></param>
        private void OnBackward(object sender, RoutedEventArgs e)
        {
            if (CurrentPage.NavigationService.CanGoBack)
            {
                CurrentPage.NavigationService.GoBack();
            }
        }

        /// <summary>
        /// The OnForward
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="RoutedEventArgs" /></param>
        private void OnForward(object sender, RoutedEventArgs e)
        {
            if (CurrentPage.NavigationService.CanGoForward)
            {
                CurrentPage.NavigationService.GoForward();
            }
        }

        /// <summary>
        /// The OnRefresh
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="RoutedEventArgs" /></param>
        private void OnRefresh(object sender, RoutedEventArgs e)
        {
            CurrentPage.NavigationService.Refresh();
        }

        private async void SetUserInfo()
        {
            User userInfo = await _spotify.GetSignedUserAsync();
            UserDisplayName.Text = userInfo.DisplayName;

            if (userInfo.Images.Count > 0)
            {
                UserImage.ImageSource = new BitmapImage(new Uri(userInfo.Images[0].Url, UriKind.RelativeOrAbsolute));
            }
        }

        //private void NavigateToArtistPage(object sender, RoutedEventArgs e)
        //{
        //    SearchArtistsPage.Content = new ArtistPage();
        //}

        #endregion Private Methods

        private void HandleClickPlay(object sender, RoutedEventArgs e)
        {
            _mediaPlayer.TogglePlay();
            MaterialDesignThemes.Wpf.ButtonProgressAssist.SetIsIndeterminate(btnClick, _mediaPlayer.isPlaying);
        }
    }
}