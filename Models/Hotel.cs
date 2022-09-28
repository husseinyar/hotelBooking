using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Models
{
    public class  Hotel
    {
        private readonly ReservationBook _ReservationBook;
        public string Name { get;}

        public Hotel(string name)
        {
            Name = name;

            _ReservationBook = new ReservationBook();
           
        }

        public IEnumerable<Reservation> GetReservationForUser(string UserName)
        {
            return _ReservationBook .GetReservationForUser(UserName);
        }

        public void MakeReservation(Reservation reservation)
        {
            _ReservationBook.AddRerverstion(reservation);
        }
    }
}
