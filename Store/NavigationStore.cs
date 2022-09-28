using HotelBooking.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Store
{
    public class NavigationStore
    {

        private ViewModelBas _currentViewModel;

        public ViewModelBas currentViewModel
            
           {
             get => _currentViewModel;
            set
            {
              _currentViewModel= value;
                onCurrentViewModelChanged();

             }

          }

       

        public event Action CurrentViewModelChanged;
        private void onCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

    }
}
