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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TP.Models;
using TP.ViewModels;
using TP.Views;

namespace TP
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class HomePage : IView
    {
        public HomePage ()
        {
            InitializeComponent();
            
            DataContext = new HomePageViewModels();
                   
        }
    }
}
