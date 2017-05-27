using System;
using Xamarin.Forms;
using Prism.Mvvm;
using Prism.Navigation;
using KartyModel;

namespace Karty.ViewModels
{
    class LoginPageViewModel : BaseViewModel
    {
        public UserDTO UserLoginDetails { get; set; }
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