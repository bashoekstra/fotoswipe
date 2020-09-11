using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using mobile_test.Models;
using mobile_test.ViewModels;
using System.IO;
using System.Threading.Tasks;

namespace mobile_test.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
        public interface IPhotoPickerService
        {
            Task<Stream> GetImageStreamAsync();
        }


    }
}