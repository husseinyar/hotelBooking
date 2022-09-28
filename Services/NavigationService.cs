using HotelBooking.Store;
using HotelBooking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Services
{
    public class NavigationService
    {
        private readonly NavigationStore _navigationstore;
        private readonly Func<ViewModelBas> _createViewModel;

        public NavigationService(NavigationStore navigationstore, Func<ViewModelBas> createViewModel)
        {
            _navigationstore = navigationstore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            _navigationstore.currentViewModel = _createViewModel();
        }
    }
}
