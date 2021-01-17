using System;

using UWPTemplateCaliburn_micro.ViewModels;

using Windows.UI.Xaml.Controls;

namespace UWPTemplateCaliburn_micro.Views
{
    public sealed partial class ImageGalleryPage : Page
    {
        public ImageGalleryPage()
        {
            InitializeComponent();
        }

        private ImageGalleryViewModel ViewModel
        {
            get { return DataContext as ImageGalleryViewModel; }
        }
    }
}
