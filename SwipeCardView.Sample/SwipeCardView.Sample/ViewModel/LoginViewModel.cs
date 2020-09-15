using SwipeCardView.Sample.View;
using SwipeCardView.Sample.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SwipeCardView.Sample.ViewModel
{
    public class LoginViewModel : BasePageViewModel
    {
        //public Command LoginCommand { get; }
        //public Command createCommand { get; }

        //public LoginViewModel()
        //{
        //    LoginCommand = new Command(OnLoginClicked);
        //    createCommand = new Command(OnCreateClicked);
        //}

        //private async void OnLoginClicked(object obj)
        //{
        //    // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
        //    await Shell.Current.GoToAsync($"//{nameof(AboutPage)}"); // to be changed
        //}

        private async void OnCreateClicked(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        public LoginViewModel(INavigation navigation)
        {
            Navigation = navigation;

            NavigateCommand = new Command<Type>(OnNavigateCommand);
        }

        public ICommand NavigateCommand { get; private set; }
        private INavigation Navigation { get; set; }

        private async void OnNavigateCommand(Type pageType)
        {
            Page page = (Page)Activator.CreateInstance(pageType);
            await Navigation.PushAsync(page);
        }
    }
}
