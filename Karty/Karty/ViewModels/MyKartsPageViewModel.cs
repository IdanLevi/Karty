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
    public class MyKartsPageViewModel : BaseViewModel
    {
        public Command AddKartCommand { get; set; }
        public List<Kart> Karts { get; set; }
        public Command SelectedCommand { get; set; }

        private Kart _selectedKart;

        public Kart SelectedKart
        {
            get { return _selectedKart; }
            set
            {
                SetProperty(ref _selectedKart, value);
                if (SelectedKart != null)
                {
                    var param = new NavigationParameters { { "kart", SelectedKart } };
                    _navigationService.NavigateAsync("KartDetailsPage", param);
                }
            }
        }

        public MyKartsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            AddKartCommand = new Command(() => this.navigateApp());
            SelectedCommand = new Command(() => this.selectedItemClickedExecute());
            Karts = AspDataService.Instance.GetMyKarts("11");
        }

        private async void selectedItemClickedExecute()
        {
            await _navigationService.NavigateAsync("CreateKartPage");

        }

        private async void navigateApp()
        {
            await _navigationService.NavigateAsync("CreateKartPage");
        }
    }
}