using Karty.Models;
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
    public class CreateKartPageViewModel : BaseViewModel
    {
        public Command AddKartCommand { get; set; }
        public Kart Kart { get; set; }
        public Command AddMemberCommand { get; set; }
        public String UserEmail { get; set; }

        public CreateKartPageViewModel(INavigationService navigationService): base(navigationService)
        {
            _navigationService = navigationService;
            AddKartCommand = new Command(() => this.createKart());
            Kart = new Kart();
            AddMemberCommand = new Command(() => this.addMember());
            Kart.Members = new List<User>();
        }

        private async void createKart()
        {
            AspDataService.Instance.CreateKart(Kart);
            Kart = new Kart();
            this.navigateKartsPage();
        }

        private void addMember()
        {
            Kart.Members.Add(new User() { Email = UserEmail });
        }

        private async void navigateKartsPage()
        {
            await _navigationService.NavigateAsync("MyKartsPage");
        }
    }
}