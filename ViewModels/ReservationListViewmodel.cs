using HotelBooking.Command;
using HotelBooking.Models;
using HotelBooking.Store;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelBooking.ViewModels
{
    public class ReservationListViewmodel:ViewModelBas
    {
        private readonly ObservableCollection<ReservationViewModel> _reservations;
       

        public IEnumerable<ReservationViewModel> Reservations => _reservations;   

        public ICommand MakeRservationCommand { get; }
        public ReservationListViewmodel( Services.NavigationService MakeReservatinNavigationservice)
        {
            _reservations = new ObservableCollection<ReservationViewModel>();
            MakeRservationCommand = new NavigateCommand(MakeReservatinNavigationservice);

            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "hussein Star", DateTime.MaxValue, DateTime.MaxValue)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(3, 2), "jo Star", DateTime.MaxValue, DateTime.MaxValue)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(4, 2), "hus Star", DateTime.MaxValue, DateTime.MaxValue)));

        }

    }
}
