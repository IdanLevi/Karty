using System;
using Karty.Models;
using Xamarin.Forms;
using Prism.Mvvm;
using Prism.Navigation;

namespace Karty.ViewModels
{
    class LoginPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        public User UserLoginDetails { get; set; }
        public Command LoginCommand { get; set; }

        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            LoginCommand = new Command(() => this.navigateApp());
        }

        private async void navigateApp()
        {
            await _navigationService.NavigateAsync("MyKartsPage");
        }
    }
}