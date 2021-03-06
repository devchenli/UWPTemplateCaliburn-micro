﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

using Caliburn.Micro;

using UWPTemplateCaliburn_micro.Core.Models;
using UWPTemplateCaliburn_micro.Core.Services;
using UWPTemplateCaliburn_micro.Helpers;
using UWPTemplateCaliburn_micro.Services;

namespace UWPTemplateCaliburn_micro.ViewModels
{
    public class ImageGalleryViewModel : Screen
    {
        public const string ImageGallerySelectedIdKey = "ImageGallerySelectedIdKey";

        private readonly INavigationService _navigationService;
        private readonly IConnectedAnimationService _connectedAnimationService;

        public BindableCollection<SampleImage> Source { get; } = new BindableCollection<SampleImage>();

        public ImageGalleryViewModel(INavigationService navigationService, IConnectedAnimationService connectedAnimationService)
        {
            _navigationService = navigationService;
            _connectedAnimationService = connectedAnimationService;
        }

        protected override async void OnInitialize()
        {
            base.OnInitialize();
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            Source.AddRange(await SampleDataService.GetImageGalleryDataAsync("ms-appx:///Assets"));
        }

        public void OnImageSelected(SampleImage image)
        {
            ImagesNavigationHelper.AddImageId(ImageGallerySelectedIdKey, image.ID);
            _connectedAnimationService.SetListDataItemForNextConnectedAnimation(image);
            _navigationService.For<ImageGalleryDetailViewModel>()
                .WithParam(v => v.ID, image.ID)
                .Navigate();
        }
    }
}
