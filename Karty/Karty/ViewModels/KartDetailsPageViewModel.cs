using System;
using Karty.Models;
using Prism.Navigation;
using Xamarin.Forms;

namespace Karty.ViewModels
{
    public class KartDetailsPageViewModel : BaseViewModel, INavigationAware
    {
        private Kart _kart;
        public Kart Kart
        {
            get { return this._kart; }
            set
            {
                SetProperty(ref this._kart, value);
                //this.RaisePropertyChanged("Kart");
            }
        }

        public Command AddItemCommand { get; set; }
        public Command ShowMemebersCommand { get; set; }

        public KartDetailsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            AddItemCommand = new Command(() => this.navigateToAddItemPage());
            ShowMemebersCommand = new Command(() => this.navigateToShowMembersPage());
            // need to remove this line when binding will work prefectly
            Kart = AspDataService.Instance.GetKart("Kart 3");
        }

        private async void navigateToShowMembersPage()
        {
            var param = new NavigationParameters { { "kartId", Kart.Id } };
            await _navigationService.NavigateAsync("ShowMembersPage", param);
        }

        private async void navigateToAddItemPage()
        {
            var param = new NavigationParameters { { "kartId", Kart.Id } };
            await _navigationService.NavigateAsync("AddKartItemPage", param);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            String kartId = (String)parameters["kartId"];

            Kart = AspDataService.Instance.GetKart(kartId);
        }
    }
}