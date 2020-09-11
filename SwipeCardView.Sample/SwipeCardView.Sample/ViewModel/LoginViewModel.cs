using mobile_test.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace mobile_test.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command createCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            createCommand = new Command(OnCreateClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}"); // to be changed
        }

        private async void OnCreateClicked(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }
    }
}
