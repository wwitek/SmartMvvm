using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using SmartMvvm.ViewModels.Interfaces;

namespace SmartMvvm.ViewModels
{
    public class StartPageViewModel : BasePageViewModel
    {
        public StartPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Title = "This is start page!";
        }

        public new ICommand StartCommand
        {
            get { return new RelayCommand(() => NavigationService.Navigate(new SecondPageViewModel(NavigationService, null))); }
            //get { return new RelayCommand(() => NavigationService.Navigate<SecondPageViewModel>()); }
        }
    }
}
