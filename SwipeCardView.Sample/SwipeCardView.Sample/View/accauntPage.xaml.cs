using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using mobile_test.Models;
using mobile_test.Views;
using mobile_test.ViewModels;

namespace mobile_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class accauntPage : ContentPage
    {
        accauntViewModel _viewModel;
        public accauntPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new accauntViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

    }
}