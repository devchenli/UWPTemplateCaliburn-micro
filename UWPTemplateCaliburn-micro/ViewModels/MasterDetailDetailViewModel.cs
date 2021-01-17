using System;

using Caliburn.Micro;

using UWPTemplateCaliburn_micro.Core.Models;

namespace UWPTemplateCaliburn_micro.ViewModels
{
    public class MasterDetailDetailViewModel : Screen
    {
        public MasterDetailDetailViewModel(SampleOrder item)
        {
            Item = item;
        }

        public SampleOrder Item { get; }
    }
}
