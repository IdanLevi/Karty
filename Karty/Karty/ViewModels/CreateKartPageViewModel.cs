using Karty.Models;
using Karty.DTOs;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Karty.ViewModels
{
    class CreateKartPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        public Command AddKartCommand { get; set; }
        public KartDTO Kart { get; set; }

        public CreateKartPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            AddKartCommand = new Command(() => this.navigateApp());
            Kart = new KartDTO();
        }

        private async void navigateApp()
        {
            AspDataService.Instance.CreateKart(Kart);
            Kart = new KartDTO();
            await _navigationService.NavigateAsync("MyKartsPage");
        }
    }
}