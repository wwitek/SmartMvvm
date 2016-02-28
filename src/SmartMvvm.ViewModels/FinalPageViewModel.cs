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
    public class FinalPageViewModel : BasePageViewModel
    {
        public FinalPageViewModel(INavigationService navigationService, Hello hello, string param1, int param2)
            : base(navigationService)
        {
            Debug.WriteLine(GetType().Name + " created.");
            Title = "Final page! " + hello.SayHello() + ". P1=" + param1 + ". P2=" + param2;
        }

        public new ICommand BackToStartCommand
        {
            get { return new RelayCommand(() => NavigationService.Navigate("StartPage")); }
        }
    }
}
