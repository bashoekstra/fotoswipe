using SwipeCardView.Sample.DAL;
using SwipeCardView.Sample.Model;
using SwipeCardView.Sample.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SwipeCardView.Sample.ViewModel
{
    public class LoginPageViewModel : BasePageViewModel
    {
        public Command LoginCommand { get; }

        public string password;

        public string email;
        public Profile CurrentUser { get; set; }
        public Profile LoginAttempt { get; set; }
        protected string CheckingEmail { get; }
        public LoginPageViewModel(INavigation navigation)
        {
            LoginCommand = new Command(OnLoginClicked);
            Navigation = navigation;

            NavigateCommand = new Command<Type>(OnNavigateCommand);
        }

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        private async void OnLoginClicked()
        {
            if (password != null && email != null)
            {
                LoginAttempt = await ProfileDataStore.GetProfileAsync(email, password);
                if (LoginAttempt.Email == email && LoginAttempt.PassWord == password)
                {
                    await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
                }
                else
                {
                    await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
                }
            }
            else
            {
                Debug.WriteLine("Error");
            }
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
