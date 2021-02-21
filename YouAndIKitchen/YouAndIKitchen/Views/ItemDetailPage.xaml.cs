using System.ComponentModel;
using Xamarin.Forms;
using YouAndIKitchen.ViewModels;

namespace YouAndIKitchen.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}