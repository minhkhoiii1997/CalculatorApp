using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace YouAndIKitchen.ViewModels
{
    public class BeefViewModel : BaseViewModel
    {
        private string _garlicPowder;
        private string _oysterSauce;
        private string _soySauce;
        private string _blackPepper;
        private string _msg;
        private string _sugar;
        private string _darkSoySauce;
        private string _vegOil;
        private string _beef;

        public Command LoadPageDataCommand { get; }
        public Command SubmitCommand { get; }

        public string GarlicPowder
        {
            get => _garlicPowder;
            set
            {
                _garlicPowder = value;
                OnPropertyChanged();
            }
        }

        public string OysterSauce
        {
            get => _oysterSauce;
            set
            {
                _oysterSauce = value;
                OnPropertyChanged();
            }
        }

        public string SoySauce
        {
            get => _soySauce;
            set
            {
                _soySauce = value;
                OnPropertyChanged();
            }
        }

        public string BlackPepper
        {
            get => _blackPepper;
            set
            {
                _blackPepper = value;
                OnPropertyChanged();
            }
        }

        public string MSG
        {
            get => _msg;
            set
            {
                _msg = value;
                OnPropertyChanged();
            }
        }

        public string Sugar
        {
            get => _sugar;
            set
            {
                _sugar = value;
                OnPropertyChanged();
            }
        }

        public string DarkSoySauce
        {
            get => _darkSoySauce;
            set
            {
                _darkSoySauce = value;
                OnPropertyChanged();
            }
        }

        public string VegOil
        {
            get => _vegOil;
            set
            {
                _vegOil = value;
                OnPropertyChanged();
            }
        }

        public string Beef
        {
            get => _beef;
            set
            {
                _beef = value;
                OnPropertyChanged();
            }
        }

        public BeefViewModel()
        {
            IsBusy = true;

            GarlicPowder = "0";
            OysterSauce = "0";
            SoySauce = "0";
            BlackPepper = "0";
            MSG = "0";
            VegOil = "0";
            Sugar = "0";
            DarkSoySauce = "0";

            LoadPageDataCommand = new Command(ExecuteLoad);
            SubmitCommand = new Command(OnSubmit);
        }

        private void ExecuteLoad()
        {
            try
            {
                if(!String.IsNullOrEmpty(Beef))
                {
                    var ratio = Double.Parse(Beef) / 2.5;
                    GarlicPowder = Convert.ToString(ratio * 0.5) + " tbsp";
                    OysterSauce = Convert.ToString(ratio * 2) + " tbsp";
                    SoySauce = Convert.ToString(ratio * 5) + " tbsp";
                    BlackPepper = Convert.ToString(ratio * 0.5) + " tbsp";
                    MSG = Convert.ToString(ratio * 0.5) + " tsp";
                    Sugar = Convert.ToString(ratio * 3) + " tbsp";
                    DarkSoySauce = Convert.ToString(ratio * 1) + " tsp";
                    VegOil = Convert.ToString(ratio * 4) + " oz";
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async void OnSubmit()
        {
            ExecuteLoad();
            Beef = "";
        }
    }
}