using HotelBooking.Exceptions;
using HotelBooking.Models;
using HotelBooking.Services;
using HotelBooking.Store;
using HotelBooking.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HotelBooking
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel _hotel;

        private readonly NavigationStore _navigationStore;

        public App()
        {
            _hotel = new Hotel("Hussein star");
            _navigationStore = new NavigationStore();   
        }

    

        protected override void OnStartup(StartupEventArgs e)
        {

            _navigationStore.currentViewModel = CreateMakeReservationViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();
            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewModel()
        {
            return new MakeReservationViewModel(_hotel, new NavigationService(_navigationStore, createMakeReservationViewModel));
        }

        private ReservationListViewmodel createMakeReservationViewModel()
        {
            return new ReservationListViewmodel(new NavigationService(_navigationStore, CreateMakeReservationViewModel));
        }
    }
}
