using System;
using Xamarin.Forms;
using Prism.Mvvm;
using Prism.Navigation;
using Karty.Models;

namespace Karty.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        public User UserLoginDetails { get; set; }

        public Command LoginCommand { get; set; }

        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            LoginCommand = new Command(() => this.navigateApp());
        }

        private async void navigateApp()
        {
            await _navigationService.NavigateAsync("MyKartsPage");
        }
    }
}