using System.Threading.Tasks;
using System.Windows;
using Spotify.ClassLibrary;

namespace spotify
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class LoginDialog : Window
    {
        private Authorization _authorization = Authorization.Instance;
        private SpotifyAPI _spotify = new SpotifyAPI();

        public LoginDialog()
        {
            InitializeComponent();
        }

        private async void HandleNavigation(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            string url = e.Uri.ToString();

            if (url.StartsWith("http://localhost:3000/callback"))
            {
                Browser.Source = null;
                Browser.Dispose();
                _authorization.SetCredentials(await Authorize(url));
                NavigateToApp();
            }
        }

        private async Task<AuthResponse> Authorize(string url)
        {
            return await _spotify.GetAuthCredentials(url);
        }


        private void NavigateToApp()
        {
            Window mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }

}
