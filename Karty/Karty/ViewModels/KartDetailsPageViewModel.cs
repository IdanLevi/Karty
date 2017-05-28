using Karty.Models;
using Prism.Navigation;

namespace Karty.ViewModels
{
    public class KartDetailsPageViewModel : BaseViewModel, INavigationAware
    {
        private Kart _kart;
        public Kart Kart
        {
            get { return this._kart; }
            set
            {
                SetProperty(ref this._kart, value);
                this.RaisePropertyChanged("Kart");
            }
        }

        public KartDetailsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Kart = new Kart() { Name = "Some name" };
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Kart kart = (Kart)parameters["kart"];

            //Kart = AspDataService.Instance.GetKart(kart.Name);
            Kart.Name = kart.Name;
        }
    }
}