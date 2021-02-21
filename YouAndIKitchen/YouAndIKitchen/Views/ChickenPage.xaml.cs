using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YouAndIKitchen.ViewModels;

namespace YouAndIKitchen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChickenPage : ContentPage
    {
        public ChickenPage()
        {
            InitializeComponent();
            this.BindingContext = new ChickenViewModel();
        }
    }
}