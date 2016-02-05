using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SmartMvvm.ViewModels;

namespace SmartMvvm.UI.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow mainWindow = new MainWindow();
            var navigation = new NavigationService(mainWindow.MainFrame);

            // Set up first page
            navigation.Navigate(new StartPageViewModel(navigation));
            mainWindow.Show();
        }
    }
}
