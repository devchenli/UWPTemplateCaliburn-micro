using System;

using UWPTemplateCaliburn_micro.ViewModels;

namespace UWPTemplateCaliburn_micro.Views.MasterDetailDetail
{
    public sealed partial class DetailsView
    {
        public DetailsView()
        {
            InitializeComponent();
        }

        public MasterDetailDetailViewModel ViewModel => DataContext as MasterDetailDetailViewModel;
    }
}
