﻿using Karty.Models;
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
        public Kart Kart { get; set; }

        public CreateKartPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            AddKartCommand = new Command(() => this.navigateApp());
            Kart = new Kart();
        }

        private async void navigateApp()
        {
            AspDataService.Instance.CreateKart(Kart);
            Kart = new Kart();
            await _navigationService.NavigateAsync("MyKartsPage");
        }
    }
}