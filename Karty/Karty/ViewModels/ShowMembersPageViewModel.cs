using System;
using Karty.Models;
using Prism.Navigation;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Karty.ViewModels
{
    public class ShowMembersPageViewModel : BaseViewModel, INavigationAware
    {
        public List<User> Members { get; set; }
        public ShowMembersPageViewModel(INavigationService navigationService) : base(navigationService)
        {
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

            Members = AspDataService.Instance.GetKartMembers(kartId);
        }
    }
}