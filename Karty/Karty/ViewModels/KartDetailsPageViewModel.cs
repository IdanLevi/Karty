using KartyModel;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karty.ViewModels
{
    class KartDetailsPageViewModel : BaseViewModel, INavigationAware
    {
        private KartDetailsDTO _kart;
        public KartDetailsDTO Kart
        {
            get { return this._kart; }
            set
            {
                SetProperty(ref this._kart, value);
                this.RaisePropertyChanged("Kart");
            }
        }

        public KartDetailsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Kart = new KartDetailsDTO() { Name = "Some name" };
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            KartDTO kart = (KartDTO)parameters["kart"];

            //Kart = AspDataService.Instance.GetKart(kart.Name);
            Kart.Name = kart.Name;
        }
    }
}