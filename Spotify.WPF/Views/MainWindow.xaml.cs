    using Spotify.WPF.Views.Pages;
    using System.Windows;
    using System.Windows.Controls;
    using System;
    using System.Media;
    using System.Windows.Media;
    using Microsoft.Win32;
    using MaterialDesignThemes.Wpf;



namespace spotify
{

    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();            

            CurrentPage.Content = new HomePage();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The Button_Click
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="RoutedEventArgs" /></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        /// <summary>
        /// The Button_Click_1
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="RoutedEventArgs" /></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        /// <summary>
        /// The Button_Click_2
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="RoutedEventArgs" /></param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
        }

        /// <summary>
        /// The CheckBox_Checked
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="RoutedEventArgs" /></param>
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
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
        private void NavigateToPlaylistsPage(object sender, RoutedEventArgs e)
        {
            CurrentPage.Content = new PlaylistsPage();
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

        /// <summary>
        /// The ScrollViewer_Scroll
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">
        /// The e <see cref="System.Windows.Controls.Primitives.ScrollEventArgs" />
        /// </param>
        private void ScrollViewer_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
        }

        /// <summary>
        /// The Slider_ValueChanged
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="RoutedPropertyChangedEventArgs{double}" /></param>
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        }

        //private void NavigateToArtistPage(object sender, RoutedEventArgs e)
        //{
        //    SearchArtistsPage.Content = new ArtistPage();
        //}

        /// <summary>
        /// The TextBox_TextChanged
        /// </summary>
        /// <param name="sender">The sender <see cref="object" /></param>
        /// <param name="e">The e <see cref="TextChangedEventArgs" /></param>
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        #endregion Private Methods

                       

        //private void btnPlay(object sender, RoutedEventArgs e)
        //{
        //    string song = (string)sender;

        //    bunifuMediaPlayer1.player.URL = song;
        //}
    }
}