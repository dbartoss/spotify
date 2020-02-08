using System;
using System.Windows;
using System.Windows.Controls;

namespace Spotify.WPF.Helpers
{
    public static class WebBrowserUtility
    {
        #region Public Fields

        public static readonly DependencyProperty BindableSourceProperty =
            DependencyProperty.RegisterAttached("BindableSource", typeof(string), typeof(WebBrowserUtility), new UIPropertyMetadata(null, BindableSourcePropertyChanged));

        #endregion Public Fields

        #region Public Methods

        public static void BindableSourcePropertyChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            if (o is WebBrowser browser)
            {
                string uri = e.NewValue as string;
                browser.Source = !String.IsNullOrEmpty(uri) ? new Uri(uri) : null;
            }
        }

        public static string GetBindableSource(DependencyObject obj)
        {
            return (string)obj.GetValue(BindableSourceProperty);
        }

        public static void SetBindableSource(DependencyObject obj, string value)
        {
            obj.SetValue(BindableSourceProperty, value);
        }

        #endregion Public Methods
    }
}