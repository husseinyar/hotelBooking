using HotelBooking.Models;
using HotelBooking.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.ViewModels
{
    public class MainViewModel:ViewModelBas
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBas CurrentViewModel => _navigationStore.currentViewModel;
        

      

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += NavigationStore_CurrentViewModelChanged;
        }

        private void NavigationStore_CurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
