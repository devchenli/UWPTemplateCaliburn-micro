using System;

using UWPTemplateCaliburn_micro.ViewModels;

namespace UWPTemplateCaliburn_micro.Views.MasterDetailDetail
{
    public sealed partial class MasterView
    {
        public MasterView()
        {
            InitializeComponent();
        }

        public MasterDetailDetailViewModel ViewModel => DataContext as MasterDetailDetailViewModel;
    }
}
