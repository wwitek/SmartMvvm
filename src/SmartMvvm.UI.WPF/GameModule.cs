using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using SmartMvvm.Domain;
using SmartMvvm.UI.WPF.Pages;
using SmartMvvm.ViewModels;
using SmartMvvm.ViewModels.Interfaces;
using INavigationService = SmartMvvm.ViewModels.Interfaces.INavigationService;

namespace SmartMvvm.UI.WPF
{
    public class GameModule : NinjectModule
    {
        public override void Load()
        {
            Bind<Hello>().ToSelf().InSingletonScope()
                .WithConstructorArgument("name", "John");

            Bind<MainWindow>().ToSelf().InSingletonScope();

            MainWindow mainWindow = Kernel.Get<MainWindow>();
            Bind<INavigationService>().To<NavigationService>().InSingletonScope()
                .WithConstructorArgument("frame", mainWindow.MainFrame);

            INavigationService navigationService = Kernel.Get<INavigationService>();
            Bind<StartPageViewModel>().To<StartPageViewModel>()
                .WithConstructorArgument("navigationService", navigationService);

            Hello hello = Kernel.Get<Hello>();
            Bind<SecondPageViewModel>().To<SecondPageViewModel>()
                .WithConstructorArgument("navigationService", navigationService)
                .WithConstructorArgument("hello", hello);

            SecondPageViewModel secondPageViewModel = Kernel.Get<SecondPageViewModel>();
            Bind<SecondPage>().To<SecondPage>()
                .WithConstructorArgument("viewModel", secondPageViewModel);

            StartPageViewModel startPageViewModel = Kernel.Get<StartPageViewModel>();
            Bind<StartPage>().To<StartPage>()
                .WithConstructorArgument("viewModel", startPageViewModel);;
        }
    }
}
