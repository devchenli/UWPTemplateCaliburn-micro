using System;

using UWPTemplateCaliburn_micro.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPTemplateCaliburn_micro.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }
    }
}
