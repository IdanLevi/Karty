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
        public Command AddMemberCommand { get; set; }
        public KartDetailsDTO Kart { get; set; }
        public String UserEmail { get; set; }

        public CreateKartPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            AddKartCommand = new Command(() => this.createKart());
            AddMemberCommand = new Command(() => this.addMember());
            Kart = new KartDetailsDTO();
        }

        private async void createKart()
        {
            AspDataService.Instance.CreateKart(Kart);
            Kart = new KartDetailsDTO();
            this.navigateKartsPage();
        }

        private async void addMember()
        {
            Kart.Members.Add(new UserDTO() { Email = UserEmail });
        }

        private async void navigateKartsPage()
        {
            await _navigationService.NavigateAsync("MyKartsPage");
        }
    }
}