using KartyModel;
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
    class CreateKartPageViewModel : BaseViewModel
    {
        public Command AddKartCommand { get; set; }
        public Command AddMemberCommand { get; set; }
        public KartDetailsDTO Kart { get; set; }
        public String UserEmail { get; set; }

        public CreateKartPageViewModel(INavigationService navigationService): base(navigationService)
        {
            AddKartCommand = new Command(() => this.createKart());
            AddMemberCommand = new Command(() => this.addMember());
            Kart = new KartDetailsDTO();
            Kart.Members = new List<UserDTO>();
        }

        private async void createKart()
        {
            AspDataService.Instance.CreateKart(Kart);
            Kart = new KartDetailsDTO();
            this.navigateKartsPage();
        }

        private void addMember()
        {
            Kart.Members.Add(new UserDTO() { Email = UserEmail });
        }

        private async void navigateKartsPage()
        {
            await _navigationService.NavigateAsync("MyKartsPage");
        }
    }
}