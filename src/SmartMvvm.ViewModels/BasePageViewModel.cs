using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using SmartMvvm.ViewModels.Interfaces;

namespace SmartMvvm.ViewModels
{
    public class BasePageViewModel : IPageViewModel
    {
        protected readonly INavigationService NavigationService;

        public string Title { get; set; }

        public BasePageViewModel()
        {
            Debug.WriteLine("Parameterless " + GetType().Name + " created.");
            Title = "Base";
        }

        public BasePageViewModel(INavigationService navigationService)
        {
            Debug.WriteLine(GetType().Name + " created.");
            NavigationService = navigationService;
        }

        public ICommand StartCommand1 => null;
        public ICommand StartCommand2 => null;
        public ICommand BackToStartCommand => null;
    }
}
