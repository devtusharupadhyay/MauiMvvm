using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiMvvmLibrary.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly INavigation _navigation;

        public LoginViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        private string? _username;

        public string? Username
        {
            get { return _username; }
            set { _username = value; OnPropertyChanged(); }
        }

        private string? _password;

        public string? Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

        public void Login()
        {
            _navigation.PushAsync("HomePage");
            // Method intentionally left empty.
        }

    }
}
