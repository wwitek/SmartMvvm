using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
