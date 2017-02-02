using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TP.Views;
using Prism.Commands;
using Prism.Mvvm;
using TP.Models;
using Microsoft.Win32;
using System.Windows;

namespace TP.ViewModels
{
        public class ModifPageViewModels : BindableBase
        {
            /// <summary>
            /// The view link to this view model
            /// </summary>
            private readonly IView _currentView;

            public ModifPageViewModels(Character character, IView currentView)
            {
                _currentView = currentView;
                ModificationCharacter = character;

                _validateCommand = new DelegateCommand(ExecuteModificationValidation);
            }

            /// <summary>
            /// Gets the character to update
            /// </summary>
            public Character ModificationCharacter { get; private set; }

            private readonly DelegateCommand _validateCommand;
            /// <summary>
            /// Gets the validate command
            /// </summary>
            public ICommand ValidateCommand
            {
                get { return _validateCommand; }
            }

            /// <summary>
            /// Validate the modification
            /// </summary>
            private void ExecuteModificationValidation()
            {
            MessageBox.Show("Your application is update !", "Notification");
            _currentView.Close();  
            }

    }
}
