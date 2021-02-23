using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace YouAndIKitchen.ViewModels
{
    public class PorkViewModel : BaseViewModel
    {
        private string _garlicPowder;
        private string _fishSauce;
        private string _soySauce;
        private string _blackPepper;
        private string _msg;
        private string _sugar;
        private string _lemongrass;
        private string _condenseMilk;
        private string _fiveSpicePowder;
        private string _chickenFlavorMix;
        private string _honey;
        private string _annattoOil;
        private string _vegOil;
        private string _pork;

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

        public string FishSauce
        {
            get => _fishSauce;
            set
            {
                _fishSauce = value;
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

        public string Lemongrass
        {
            get => _lemongrass;
            set
            {
                _lemongrass = value;
                OnPropertyChanged();
            }
        }

        public string CondenseMilk
        {
            get => _condenseMilk;
            set
            {
                _condenseMilk = value;
                OnPropertyChanged();
            }
        }

        public string FiveSpicePowder
        {
            get => _fiveSpicePowder;
            set
            {
                _fiveSpicePowder = value;
                OnPropertyChanged();
            }
        }

        public string ChickenFlavorMix
        {
            get => _chickenFlavorMix;
            set
            {
                _chickenFlavorMix = value;
                OnPropertyChanged();
            }
        }

        public string Honey
        {
            get => _honey;
            set
            {
                _honey = value;
                OnPropertyChanged();
            }
        }

        public string AnnattoOil
        {
            get => _annattoOil;
            set
            {
                _annattoOil = value;
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

        public string Pork
        {
            get => _pork;
            set
            {
                _pork = value;
                OnPropertyChanged();
            }
        }

        public PorkViewModel()
        {
            IsBusy = true;

            GarlicPowder = "0";
            FishSauce = "0";
            SoySauce = "0";
            BlackPepper = "0";
            MSG = "0";
            Lemongrass = "0";
            Sugar = "0";
            CondenseMilk = "0";
            FiveSpicePowder = "0";
            ChickenFlavorMix = "0";
            Honey = "0";
            AnnattoOil = "0";
            VegOil = "0";

            LoadPageDataCommand = new Command(ExecuteLoad);
            SubmitCommand = new Command(OnSubmit);
        }

        private void ExecuteLoad()
        {
            try
            {
                if (!String.IsNullOrEmpty(Pork))
                {
                    var ratio = Double.Parse(Pork) / 2.5;
                    FishSauce = Convert.ToString(ratio * 65) + " ml";
                    MSG = Convert.ToString(ratio * 1) + " tbsp";
                    Sugar = Convert.ToString(ratio * (19/3)) + " tbsp";
                    SoySauce = Convert.ToString(ratio * 2) + " tbsp";
                    Lemongrass = Convert.ToString(ratio * 2) + " tbsp";
                    CondenseMilk = Convert.ToString(ratio * 2) + " tbsp";
                    FiveSpicePowder = Convert.ToString(ratio * 1) + " tsp";
                    ChickenFlavorMix = Convert.ToString(ratio * 0.5) + " tsp";
                    BlackPepper = Convert.ToString(ratio * 1) + " tsp";
                    GarlicPowder = Convert.ToString(ratio * 1) + " tsp";
                    Honey = Convert.ToString(ratio * 1) + " tsp";
                    AnnattoOil = Convert.ToString(ratio * 3) + " coffee spoons";
                    VegOil = Convert.ToString(ratio * 4) + "oz";
                }
            }
            catch (Exception ex)
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
            Pork = "";
        }
    }
}