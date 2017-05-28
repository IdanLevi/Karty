using Karty.Views;
using Microsoft.WindowsAzure.MobileServices;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karty
{
    public class App: PrismApplication
    {
        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("LoginPage");

            if (AppManager.IsLoggedIn)
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new LoginPage();
            }
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<LoginPage>("LoginPage");
            Container.RegisterTypeForNavigation<MyKartsPage>("MyKartsPage");
            Container.RegisterTypeForNavigation<CreateKartPage>("CreateKartPage");
            Container.RegisterTypeForNavigation<KartDetailsPage>("KartDetailsPage");
            Container.RegisterTypeForNavigation<AddKartItemPage>("AddKartItemPage");
            Container.RegisterTypeForNavigation<ShowMembersPage>("ShowMembersPage");
        }

        public static IMobileServiceClient Client { get; private set; }
    }
}
