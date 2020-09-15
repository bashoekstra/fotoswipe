using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwipeCardView.Sample.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwipeCardView.Sample.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            //this.BindingContext = new LoginViewModel();
            BindingContext = new LoginViewModel(Navigation);
        }
    }
}