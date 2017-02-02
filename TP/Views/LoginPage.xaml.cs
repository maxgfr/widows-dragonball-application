using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TP.ViewModels;
using TP.Views;

namespace TP
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class LoginPage : IView
    {
        public LoginPage()
        {
            InitializeComponent();

            DataContext = new LoginPageViewModels(this, new HomePage());

        }
    }
}
