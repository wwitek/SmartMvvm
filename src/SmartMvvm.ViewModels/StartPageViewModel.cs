using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
