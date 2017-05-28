using System;
using Karty.Models;
using Prism.Navigation;
using Xamarin.Forms;

namespace Karty.ViewModels
{
    public class AddKartItemPageViewModel : BaseViewModel, INavigationAware
    {
        public Command AddItemCommand { get; set; }
        public Item Item { get; set; }
        private String _kartId;

        public AddKartItemPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            AddItemCommand = new Command(() => this.createItem());
            Item = new Item();
        }

        private async void createItem()
        {
            AspDataService.Instance.CreateItem(Item);
            var param = new NavigationParameters { { "kartId", _kartId } };
            await _navigationService.NavigateAsync("KartDetailsPage", param);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            _kartId = (String)parameters["kartId"];
            Item.KartId = _kartId;
        }
    }
}