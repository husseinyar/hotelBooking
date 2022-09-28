using HotelBooking.Exceptions;
using HotelBooking.Models;
using HotelBooking.Services;
using HotelBooking.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HotelBooking.Command
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly Hotel _hotel;
        private readonly NavigationService reservationViewNavigation;
        private readonly MakeReservationViewModel _makeReservationViewModel;
       

       

        public MakeReservationCommand(Hotel hotel)
        {
            _hotel = hotel;
        }

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel, NavigationService reservationViewNavigation)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
            this.reservationViewNavigation = reservationViewNavigation;
            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        public override bool CanExecute(object? parameter)
        {
            return  !string.IsNullOrEmpty(_makeReservationViewModel.Useriname)&&base.CanExecute(parameter);
        }
        public override void Execute(object? parameter)
        {
            Reservation reservation = new Reservation(
               
                new RoomID(_makeReservationViewModel.FloorNumber, 
                _makeReservationViewModel.RoomNumbers),
                  _makeReservationViewModel.Useriname,
                _makeReservationViewModel.StartTime,
                _makeReservationViewModel.EndtTime

                );
            try
            {
                _hotel.MakeReservation(reservation);
                MessageBox.Show("successfully reserved", " Scuccess",
                   MessageBoxButton.OK, MessageBoxImage.Information);
                reservationViewNavigation.Navigate();
            }
            catch (ReservationConflictsEXception)
            {

                MessageBox.Show("this Room is Alredy taken"," ERRor",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }

           


        }
        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(MakeReservationViewModel.Useriname))
             {
                onCanExecuteChanged();
             }
        }

    }
}
