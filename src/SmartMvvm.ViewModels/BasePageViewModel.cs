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
    public class BasePageViewModel : IPageViewModel
    {
        protected readonly INavigationService NavigationService;

        public string Title { get; set; }

        public BasePageViewModel()
        {
            Title = "Base";
        }

        public BasePageViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public ICommand StartCommand => null;
        public ICommand BackToStartCommand => null;
    }
}
