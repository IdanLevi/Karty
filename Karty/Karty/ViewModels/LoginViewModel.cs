using Karty.Models;
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
        }
    }
}
