   M S B A M L   `   `   `  ????G  CHotelBooking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:HotelBooking.ViewsHotelBooking.Views  5      A%clr-namespace:HotelBooking.ViewModelsHotelBooking.ViewModels  6=   ,    &HotelBooking.Views.MakeReservationView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:HotelBooking.Views     5      <
viewmodels%clr-namespace:HotelBooking.ViewModels     6=   .??5	      ?   ? RowDefinitions  5
   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5   
   ?? $??0??5      $??25(?5      $??Make Reservation??5      ? 5   
   $??1??6     5      ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   .+?5      ?? $??0??5      $??25(?5      $??UserName??5      ?? 5      $??1??5      $??25(?5       $??0 5 0 0q?5!      ?? 5#      $??1??5$      $??25(?5%      $??0 5 0 0q?5&      ??5'      ?? *	Useriname+ ?? UpdateSourceTrigger$ PropertyChanged=?5(      ? 5*      $??2??6     5+      ?? 5,      $
??auto ?6   ?? 5-      $
??auto ?6    ? ColumnDefinitions 5/      ?? 50      $
??auto ?6#    z? SharedSizeGroup$ FirstColumn??60   ?? 51      $
??auto ?6#   $ secondColum??61   .+?53      ?? $??0??54      $??0??55      $??25(?57      $??Floor No??58      ?? 59      $??1??5:      $??0??5;      $??25(?5<      $??5 5 0 0q?5=   P   ??6   ?? *FloorNumber+$ PropertyChanged=?6P   ?? 5>      $??0??5?      $??1??5@      $??25(?5A      $??	10 0  0 5q?5B      $??Room No??5C      ?? 5D      $??1??5E      $??1??5F      $??25(?5G      $??10 5 0 0q?5H   P   ??6   ?? *RoomNumbers+$ PropertyChanged=?6P   5J      ? 5L   
   $??3??6   $??0 10 0 0q?6     5M      ?? 5N      $
??auto ?6    ?? 5O      $
??auto ?6     5Q      ?? 5R      $
??auto ?6#   $ FirstColumn??60   ?? 5S      $
??auto ?6#   $ secondColum??61   .+?5U      ?? $??0??5V      $??0??5W      $??25(?5X      $??	StartDate??5Y      (  "System.Windows.Controls.DatePicker  5Z      $??1??5[      $??0??5\      $??5 5 0 0q?5^         SelectedDate 5_      ?? *	StartTime+$ PropertyChanged=??? 5a      $??0??5b      $??1??5c      $??25(?5d      $??	10 0  0 5q?5e      $??EndDate??5f        5g      $??1??5h      $??1??5i      $??10 5 0 0q?5l       5k      ?? *
EndtTime+$ PropertyChanged=?5l      5n      ?? 5o   
    ?? Orientation$ 
Horizontal=?6   $??4??6.   $??0 10 0 0q?6;   .+?5p      ?? $??Submit??6   $??50??6J   $	??100??6V   $??Center=?6b   ??6&   ?? *SubmitCommand+6b   ?? 5q      $??Cancel??6   $??10 0 0 0q?6J   $??50??6\   $	??100??6h   $??Center=?6u   ??6&   ?? *CancelCommand+6u   5r      5t      5u      