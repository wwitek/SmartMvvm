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
    public class SecondPageViewModel : BasePageViewModel
    {
        public SecondPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Title = "Second page!";
        }

        public new ICommand BackToStartCommand
        {
            get { return new RelayCommand(() => NavigationService.Navigate(new StartPageViewModel(NavigationService))); }
        }
    }
}
