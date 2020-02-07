using System.Windows;
using System.Windows.Controls;
using Spotify.WPF.Views.Pages;

namespace spotify
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void ScrollViewer_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void NavigateToHomePage(object sender, RoutedEventArgs e)
        {
            CurrentPage.Content = new HomePage();
        }

        private void NavigateToPlaylistsPage(object sender, RoutedEventArgs e)
        {
            CurrentPage.Content = new PlaylistsPage();
        }

        private void NavigateToSearchArtistsPage(object sender, RoutedEventArgs e)
        {
            CurrentPage.Content = new SearchArtistsPage();
        }

        private void LogOut(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}