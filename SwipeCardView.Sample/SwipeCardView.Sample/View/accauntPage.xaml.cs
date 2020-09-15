using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SwipeCardView.Sample.Model;
using SwipeCardView.Sample.View;
using SwipeCardView.Sample.ViewModel;

namespace SwipeCardView.Sample.View
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