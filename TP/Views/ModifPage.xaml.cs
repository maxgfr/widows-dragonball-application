using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using TP.Models;
using TP.ViewModels;

namespace TP.Views
{
    /// <summary>
    /// Logique d'interaction pour ModifPage.xaml
    /// </summary>
    public partial class ModifPage : IView
    {
        public ModifPage(Character character)
        {
            InitializeComponent();

            DataContext = new ModifPageViewModels(character, this);
        }

        private void OnButton_ClickDescription(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                Description.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void OnButtonClick_Image(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                Image.Text = openFileDialog.FileName;
        }

        private void OnButton_ClickImageTransfo(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
                ImageTransfo.Text = openFileDialog.FileName;
        }
    }

}
