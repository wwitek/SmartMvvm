using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public GameModule()
        {
            Debug.WriteLine(GetType().Name + " created.");
        }

        public override void Load()
        {
            Bind<Hello>().ToSelf().InSingletonScope()
                .WithConstructorArgument("name", "John");
            Bind<MainWindow>().ToSelf().InSingletonScope();

            MainWindow mainWindow = Kernel.Get<MainWindow>();
            Bind<INavigationService>().To<NavigationService>().InSingletonScope()
                .WithConstructorArgument("frame", mainWindow.MainFrame);

            Hello hello = Kernel.Get<Hello>();
            INavigationService navigationService = Kernel.Get<INavigationService>();

            Bind<FinalPageViewModel>().To<FinalPageViewModel>()
                .Named("Final1Page")
                .WithConstructorArgument("navigationService", navigationService)
                .WithConstructorArgument("hello", hello)
                .WithConstructorArgument("param1", "AAA")
                .WithConstructorArgument("param2", 111);

            Bind<FinalPageViewModel>().To<FinalPageViewModel>()
                .Named("Final2Page")
                .WithConstructorArgument("navigationService", navigationService)
                .WithConstructorArgument("hello", hello)
                .WithConstructorArgument("param1", "BBB")
                .WithConstructorArgument("param2", 999);

            Bind<StartPageViewModel>().To<StartPageViewModel>()
                .WithConstructorArgument("navigationService", navigationService);
        }
    }
}
