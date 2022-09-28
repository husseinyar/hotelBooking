using HotelBooking.Command;
using HotelBooking.Models;
using HotelBooking.Services;
using HotelBooking.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelBooking.ViewModels
{
    public class MakeReservationViewModel : ViewModelBas
    {

        private string _userName;
        private int _roomNumbers;
        private int _floorNumbers;
        private DateTime _startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 6);
        private DateTime _endtTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 20);
        private Hotel hotel;
     
        

        public string Useriname
        {
            get {
                return _userName;
            }
            set {
                _userName = value;
                OnPropertyChanged(nameof(Useriname));
            }
        }

        
        public int RoomNumbers
        {
            get
            {
                return _roomNumbers;
            }
            set
            {
                _roomNumbers = value;
                OnPropertyChanged(nameof(RoomNumbers));
            }
        }
     
        public int FloorNumber
        {
            get
            {
                return _floorNumbers;
            }
            set
            {
                _floorNumbers = value;
                OnPropertyChanged(nameof(FloorNumber));
            }
        }

       
        public DateTime StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
                OnPropertyChanged(nameof(StartTime));
            }
        }
       
        public DateTime EndtTime
        {
            get
            {
                return _endtTime;
            }
            set
            {
                _endtTime = value;
                OnPropertyChanged(nameof(EndtTime));
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public MakeReservationViewModel(Hotel hotel, NavigationService reservationViewNavigation)
        {
            SubmitCommand = new MakeReservationCommand(this, hotel, reservationViewNavigation);
            CancelCommand = new NavigateCommand(reservationViewNavigation);
        }

      
    }
}
