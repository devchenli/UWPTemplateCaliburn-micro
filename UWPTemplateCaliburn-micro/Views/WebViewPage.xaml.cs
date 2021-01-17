using System;

using UWPTemplateCaliburn_micro.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPTemplateCaliburn_micro.Views
{
    public sealed partial class WebViewPage : Page
    {
        public WebViewPage()
        {
            InitializeComponent();

            Loaded += (s, e) => ViewModel.Initialize(webView);
        }

        private WebViewViewModel ViewModel
        {
            get { return DataContext as WebViewViewModel; }
        }
    }
}
