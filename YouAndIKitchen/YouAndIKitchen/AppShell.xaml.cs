using System;
using System.Collections.Generic;
using Xamarin.Forms;
using YouAndIKitchen.ViewModels;
using YouAndIKitchen.Views;

namespace YouAndIKitchen
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
