using HotelBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Exceptions
{
    public class ReservationConflictsEXception : Exception
    {
        public Reservation ExistingReservation { get; }
        public Reservation IncomingReservation { get; }
        public ReservationConflictsEXception(Reservation existingReservation, Reservation incomingReservation)
        {
            ExistingReservation = existingReservation;
            IncomingReservation = incomingReservation;
        }
        public ReservationConflictsEXception()
        {
            
        }

        public ReservationConflictsEXception(string? message) : base(message)
        {

        }

        public ReservationConflictsEXception(string? message, Exception? innerException) : base(message, innerException)
        {

        }

      

        //protected ReservationConflictsEXception(SerializationInfo info, StreamingContext context) : base(info, context)
        //{
        //}
    }
}
