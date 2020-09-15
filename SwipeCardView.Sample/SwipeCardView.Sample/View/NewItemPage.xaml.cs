using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SwipeCardView.Sample.Model;
using SwipeCardView.Sample.ViewModel;
using System.IO;
using System.Threading.Tasks;

namespace SwipeCardView.Sample.View
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel(Navigation);
        }
        public interface IPhotoPickerService
        {
            Task<Stream> GetImageStreamAsync();
        }


    }
}