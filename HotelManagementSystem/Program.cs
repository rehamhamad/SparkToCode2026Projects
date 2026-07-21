namespace HotelManagementSystem
{
    internal class Program
    {
        static List<Room> rooms = new List<Room>();
        static List<Guest> guests = new List<Guest>();

        static void Main(string[] args)
        {
            PreloadRooms();
            //Menue logic
            bool running = true;
            while (running)
            {
                PrintMenu();
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": Case01_AddNewRoom(); break;
                    case "2": Case02_RegisterNewGuest(); break;
                    case "3": Case03_BookRoom(); break;
                    case "4": Case04_ViewAllRooms(); break;
                    case "5": break;
                    case "6": break;
                    case "7": break;
                    case "8": break;
                    case "9": break;
                    case "10":break;
                    case "11":break;
                    case "12":break;
                    case "13":break;
                    case "14":break;
                    case "15":break;
                    case "0":
                        running = false;
                        Console.WriteLine("Thank you for using Grand Vista Hotel Management System. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a number from the menu.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                }
            }
        }

        static void PreloadRooms()
        {
            rooms.Add(new Room(101, "Single", 25.00m));
            rooms.Add(new Room(102, "Single", 25.00m));
            rooms.Add(new Room(201, "Double", 40.00m));
            rooms.Add(new Room(202, "Double", 42.50m));
            rooms.Add(new Room(301, "Suite", 90.00m));
            rooms.Add(new Room(302, "Suite", 110.00m));
        }

        static void PrintMenu()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("GRAND VISTA HOTEL - MANAGEMENT SYSTEM");
            Console.WriteLine("================================================");
            Console.WriteLine(" 1. Add New Room");
            Console.WriteLine(" 2. Register New Guest");
            Console.WriteLine(" 3. Book a Room for a Guest");
            Console.WriteLine(" 4. View All Rooms");
            Console.WriteLine(" 5. View All Guests");
            Console.WriteLine(" 6. Search & Filter Rooms");
            Console.WriteLine(" 7. Guest & Booking Statistics");
            Console.WriteLine(" 8. Update Room Price");
            Console.WriteLine(" 9. Guest Lookup by Name");
            Console.WriteLine("10. Room Type Breakdown Report");
            Console.WriteLine("11. Check Out a Guest");
            Console.WriteLine("12. Remove Unavailable Rooms");
            Console.WriteLine("13. Extend Guest Stay");
            Console.WriteLine("14. Highest Revenue Booking");
            Console.WriteLine("15. Guest Pagination Viewer");
            Console.WriteLine(" 0. Exit");
            Console.WriteLine("================================================");
            Console.Write("Enter your choice: ");
        }


        static int ReadPositiveInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value) && value > 0)
                    return value;
                Console.WriteLine("Invalid input. Please enter a positive whole number.");
            }
        }

        //input helpers 

        static decimal ReadPositiveDecimal(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal value) && value > 0)
                    return value;
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }

        static string ReadNonEmptyString(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();
                Console.WriteLine("Input cannot be empty.");
            }
        }

          static decimal GetPriceForGuest(Guest guest)
        {
            if (guest.RoomNumber == Guest.NoRoomAssigned) return 0m;
            Room room = rooms.FirstOrDefault(r => r.RoomNumber.ToString() == guest.RoomNumber);
            return room != null ? room.PricePerNight : 0m;
        }

        // Case 01: Add New Room
        static void Case01_AddNewRoom()
        {
            Console.WriteLine("--- Add New Room ---");
            int roomNumber = ReadPositiveInt("Enter room number: ");

            // Requirement: Use LINQ Any() for the duplicate check.
            if (rooms.Any(r => r.RoomNumber == roomNumber))
            {
                Console.WriteLine($"Error: Room {roomNumber} already exists.");
                return;
            }

            string roomType = ReadNonEmptyString("Enter room type (Single/Double/Suite): ");
            decimal price = ReadPositiveDecimal("Enter price per night: ");

            Room newRoom = new Room(roomNumber, roomType, price, true);
            rooms.Add(newRoom);

            Console.WriteLine("\nRoom added successfully!");
            newRoom.DisplayRoom();
            Console.WriteLine($"Total rooms in system: {rooms.Count}");
        }

        // Case 02: Register New Guest
        static void Case02_RegisterNewGuest()
        {
            Console.WriteLine("--- Register New Guest ---");
            string name = ReadNonEmptyString("Enter guest name: ");
            string checkInDate = ReadNonEmptyString("Enter check-in date (e.g. 2026-07-20): ");
            int nights = ReadPositiveInt("Enter number of nights: ");

            string guestId = $"G{(guests.Count + 1):D3}";
            Guest newGuest = new Guest(guestId, name, checkInDate, nights);
            guests.Add(newGuest);

            Console.WriteLine("\nGuest registered successfully!");
            Console.WriteLine($"Guest ID: {newGuest.GuestId}");
            newGuest.DisplayGuest();
        }


        // Case 03: Book a Room for a Guest
        static void Case03_BookRoom()
        {
            Console.WriteLine("--- Book a Room for a Guest ---");
            string guestId = ReadNonEmptyString("Enter guest ID: ");

            Guest guest = guests.FirstOrDefault(g => g.GuestId.Equals(guestId, StringComparison.OrdinalIgnoreCase));
            if (guest == null)
            {
                Console.WriteLine($"Error: No guest found with ID '{guestId}'.");
                return;
            }

            int roomNumber = ReadPositiveInt("Enter room number to book: ");
            Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
            if (room == null)
            {
                Console.WriteLine($"Error: No room found with number {roomNumber}.");
                return;
            }

            if (!room.IsAvailable)
            {
                Console.WriteLine("Room is already booked.");
                return;
            }
            guest.RoomNumber = room.RoomNumber.ToString();
            room.IsAvailable = false;

            decimal totalCost = guest.CalculateTotalCost(room.PricePerNight);

            Console.WriteLine("\nBooking confirmed!");
            Console.WriteLine($"Guest: {guest.GuestName}");
            Console.WriteLine($"Room: {room.RoomNumber} ({room.RoomType})");
            Console.WriteLine($"Price per night: OMR {room.PricePerNight:F2}");
            Console.WriteLine($"Total nights: {guest.TotalNights}");
            Console.WriteLine($"Total cost: OMR {totalCost:F2}");
        }

        // Case 04: View All Rooms
        static void Case04_ViewAllRooms()
        {
            Console.WriteLine("--- View All Rooms ---");
            if (!rooms.Any())
            {
                Console.WriteLine("No rooms have been added yet.");
                return;
            }

            var sortedRooms = rooms.OrderBy(r => r.RoomNumber).Select(r => r);
            Console.WriteLine($"Total rooms: {rooms.Count()}\n");
            foreach (Room room in sortedRooms)
            {
                room.DisplayRoom();
            }
        }

    }
}
