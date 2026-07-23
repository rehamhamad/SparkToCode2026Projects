using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    
        public class Guest
        {
            public string GuestId { get; set; }
            public string GuestName { get; set; }
            public string RoomNumber { get; set; }
            public string CheckInDate { get; set; }
            public int TotalNights { get; set; }

            public const string NoRoomAssigned = "Not Assigned";

            public Guest(string guestId, string guestName, string checkInDate, int totalNights,
                         string roomNumber = NoRoomAssigned)
            {
                GuestId = guestId;
                GuestName = guestName;
                CheckInDate = checkInDate;
                TotalNights = totalNights;
                RoomNumber = roomNumber;
            }

            // Prints a single formatted line describing this guest.
            public void DisplayGuest()
            {
                Console.WriteLine(
                    $"ID: {GuestId} | Name: {GuestName,-16} | Room: {RoomNumber,-12} | Check-in: {CheckInDate,-12} | Nights: {TotalNights}");
            }

            // Total cost = nights stayed * price per night of the room they hold.
            public decimal CalculateTotalCost(decimal pricePerNight)
            {
                return TotalNights * pricePerNight;
            }
        }
}
