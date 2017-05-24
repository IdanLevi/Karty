using Karty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Karty.ViewModels
{
    class LoginViewModel
    {
        public User UserLoginDetails { get; set; }
        public Command LoginClickedCommand { get; set; }

        public LoginViewModel()
        {
            LoginClickedCommand = new Command(() => this.navigateApp());
        }

        private void navigateApp()
        {
            /// navigate into my karts
        }
    }
}
