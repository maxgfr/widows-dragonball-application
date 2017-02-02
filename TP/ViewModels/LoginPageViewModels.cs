using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TP.Views;
using Prism.Commands;
using Prism.Mvvm;

namespace TP.ViewModels
{
    class LoginPageViewModels : BindableBase
    { 
        private readonly IView _currentView;
        private readonly IView _viewToOpen; 

        public LoginPageViewModels (IView currentView, IView viewToOpen)
        {
            _logUserInCommand = new DelegateCommand(LogUserIn, CanLogUserIn);

            _currentView = currentView;
            _viewToOpen = viewToOpen;
        }

        private string _login;

        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                _logUserInCommand.RaiseCanExecuteChanged();
            }
        }

        private readonly DelegateCommand _logUserInCommand;
        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            private set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public ICommand LogUserInCommand
        {
            get { return _logUserInCommand; }
        }

        private bool CanLogUserIn()
        {
            if (Login == "login")
            {
                return true;
            }
            else return false;
            //return !string.IsNullOrEmpty(Login);
        }

        private async void LogUserIn()
        {
            IsBusy = true;

            await Task.Delay(2000);

            _currentView.Close();
            _viewToOpen.Show();

            IsBusy = false;
        }
    }
}

