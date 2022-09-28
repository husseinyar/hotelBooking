using HotelBooking.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Models
{
    public class ReservationBook
    {
        private readonly  List<Reservation> _Reservation;

        public ReservationBook()
        {
            _Reservation = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservationForUser(string UserName)
        {
            return _Reservation.Where(x => x.Username == UserName);
        }

        public void AddRerverstion(Reservation reservation)
        {
            foreach (Reservation existingReservation in _Reservation)
            {
                if(existingReservation.Conflicts(reservation))
                {
                    throw new ReservationConflictsEXception(existingReservation, reservation);
                }
             
            }
           _Reservation.Add(reservation);

        }
    }
}
