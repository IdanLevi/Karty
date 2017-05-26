﻿using Karty.Models;
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
    class MyKartsPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        public Command AddKartCommand { get; set; }
        public List<KartDTO> Karts { get; set; }
        public KartDTO SelectedKart { get; set; }

        public MyKartsPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            AddKartCommand = new Command(() => this.navigateApp());
            Karts = AspDataService.Instance.GetMyKarts("11");
        }

        private async void navigateApp()
        {
            await _navigationService.NavigateAsync("CreateKartPage");
        }
    }
}