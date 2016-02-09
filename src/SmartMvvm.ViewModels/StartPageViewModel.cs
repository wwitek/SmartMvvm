using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using SmartMvvm.Domain;
using SmartMvvm.ViewModels.Interfaces;

namespace SmartMvvm.ViewModels
{
    public class StartPageViewModel : BasePageViewModel
    {
        public StartPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Debug.WriteLine(GetType().Name + " created.");
            Title = "This is start page!";
        }

        public new ICommand StartCommand1
        {
            get
            {
                Hello h = new Hello("Number 1");
                return new RelayCommand(() => NavigationService.Navigate("Final1Page"));
            }
        }

        public new ICommand StartCommand2
        {
            get
            {
                Hello h = new Hello("Number 2");
                return new RelayCommand(() => NavigationService.Navigate("Final2Page"));
            }
        }
    }
}
