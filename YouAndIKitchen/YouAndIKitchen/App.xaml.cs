﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YouAndIKitchen.Services;
using YouAndIKitchen.Views;

namespace YouAndIKitchen
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            var isLoggedIn = Xamarin.Essentials.SecureStorage.GetAsync("isLogged").Result;
            if (isLoggedIn == "1")
            {
                MainPage = new AppShell();
            }
            else
            {
                MainPage = new LoginPage();
            }

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
