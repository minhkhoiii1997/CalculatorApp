using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using YouAndIKitchen.Views;

namespace YouAndIKitchen.ViewModels
{
    public class ChickenViewModel : BaseViewModel
    {
        public Command SubmitCommand { get; }

        private string _beef;

        public string Beef
        {
            get => _beef;
            set => SetProperty(ref _beef, value);
        }

        public ChickenViewModel()
        {
            SubmitCommand = new Command(OnSubmitClicked);
        }

        public async void OnSubmitClicked(object obj)
        {
            try
            {
                if(!String.IsNullOrEmpty(Beef) && Int32.Parse(Beef) > 0)
                {

                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Failed", "You entered an invalid value", "Ok");
                }
            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Failed", "There was an error submitting the value, please try again!", "Ok");
            }
        }
    }
}