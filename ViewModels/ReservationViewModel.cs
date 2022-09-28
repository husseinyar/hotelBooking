using HotelBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.ViewModels
{
    public class ReservationViewModel:ViewModelBas
    {
        private readonly Reservation _reservation;

       

        public string RoomID =>  _reservation.RoomID.ToString();
        public string Username => _reservation.Username;
        public DateTime StartTime => _reservation.StartTime;
        public DateTime EndTime => _reservation.EndTime;
        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }


    }
}
