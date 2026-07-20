using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    // Represents a single hotel room.
    public class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public decimal PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        public Room(int roomNumber, string roomType, decimal pricePerNight, bool isAvailable = true)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;
        }

        // Prints a describtion of this room.
        public void DisplayRoom()
        {
            string status = IsAvailable ? "Available" : "Booked";
            Console.WriteLine(
                $"Room {RoomNumber,-6} | Type: {RoomType,-8} | Price: OMR {PricePerNight,9:F2}/night | Status: {status}");
        }
    }
}
