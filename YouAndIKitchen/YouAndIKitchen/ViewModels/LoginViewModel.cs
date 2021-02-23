using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using YouAndIKitchen.Views;

namespace YouAndIKitchen.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        private string _email;
        private string _password;

        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        public async void OnLoginClicked(object obj)
        {
            try
            {
                if(Email == "admin@youandikitchen.com" && Password == "123")
                {
                    Application.Current.MainPage = new AppShell();
                    await Shell.Current.GoToAsync($"//{nameof(BeefPage)}");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Failed", "Email or Password Incorrect!", "Ok");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Failed", "Email or Password Incorrect!", "Ok");
            }
        }
    }
}
