using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight.Views;
using Ninject;
using Ninject.Modules;
using SmartMvvm.ViewModels;
using INavigationService = SmartMvvm.ViewModels.Interfaces.INavigationService;

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

            IKernel kernel = new StandardKernel();
            var modules = new List<INinjectModule>
            {
                new GameModule()
            };
            kernel.Load(modules);

            MainWindow mainWindow = kernel.Get<MainWindow>();
            INavigationService navigation = kernel.Get<INavigationService>();

            // Set up first page
            navigation.Navigate(kernel.Get<StartPageViewModel>());
            mainWindow.Show();
        }
    }
}
