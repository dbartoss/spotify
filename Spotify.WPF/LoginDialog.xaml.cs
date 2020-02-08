using Spotify.ClassLibrary;
using System.Threading.Tasks;
using System.Windows;

namespace spotify
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class LoginDialog : Window
    {
        #region Private Fields

        private Authorization _authorization = Authorization.Instance;
        private SpotifyAPI _spotify = new SpotifyAPI();

        #endregion Private Fields

        #region Public Constructors

        public LoginDialog()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Private Methods

        private async Task<AuthResponse> Authorize(string url)
        {
            return await _spotify.GetAuthCredentials(url);
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

        private void NavigateToApp()
        {
            Window mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        #endregion Private Methods
    }
}