using System;
using System.Windows;

using CefSharp;
using Spotify.ClassLibrary.Authorization;

namespace spotify
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class LoginDialog : Window
    {

        private string authData;

        public LoginDialog()
        {
            InitializeComponent();
        }


        private void HandleChange(object sender, CefSharp.FrameLoadEndEventArgs e)
        {
            if (e.Url.ToString().Contains("localhost:3000/callback"))
            {
                Dispatcher.BeginInvoke((Action)(async () =>
               {
                   authData = await Browser.GetTextAsync();
                   this.SetAccessToken(authData);
               }));
            }
        }

        private void SetAccessToken(string data)
        {
            Authorization auth = Authorization.Instance;
            auth.SetDataAsTokens(data);
            this.NavigateToApp();
        }

        private void NavigateToApp()
        {
            Window window = new MainWindow();
            window.Show();
            this.Close();
        }


    }

}
