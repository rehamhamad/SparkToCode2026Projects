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
                    case "5": Case05_ViewAllGuests(); break;
                    case "6": Case06_SearchFilterRooms(); break;
                    case "7": Case07_GuestBookingStatistics(); break;
                    case "8": break;
                    case "9": break;
                    case "10": break;
                    case "11": break;
                    case "12": break;
                    case "13": break;
                    case "14": break;
                    case "15": break;
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

        // Case 05: View All Guests
        static void Case05_ViewAllGuests()
        {
            Console.WriteLine("--- View All Guests ---");
            if (!guests.Any())
            {
                Console.WriteLine("No guests have been registered yet.");
                return;
            }

            var sortedGuests = guests.OrderBy(g => g.GuestName).Select(g => g);
            Console.WriteLine($"Total guests: {guests.Count()}\n");
            foreach (Guest guest in sortedGuests)
            {
                guest.DisplayGuest();
            }
        }

        // Case 06: Search & Filter Rooms
        static void Case06_SearchFilterRooms()
        {
            bool inSubMenu = true;
            while (inSubMenu)
            {
                Console.WriteLine("\n--- Search & Filter Rooms ---");
                Console.WriteLine("1. Show all available rooms");
                Console.WriteLine("2. Filter by room type");
                Console.WriteLine("3. Filter by max price");
                Console.WriteLine("4. Room price statistics");
                Console.WriteLine("0. Back");
                Console.Write("Enter your choice: ");
                string sub = Console.ReadLine();
                Console.WriteLine();

                switch (sub)
                {
                    case "1":
                        {
                            var available = rooms.Where(r => r.IsAvailable)
                                                  .OrderBy(r => r.PricePerNight)
                                                  .ToList();
                            if (!available.Any())
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                Console.WriteLine($"Available rooms: {available.Count}");
                                foreach (Room r in available) r.DisplayRoom();
                            }
                            break;
                        }
                    case "2":
                        {
                            string type = ReadNonEmptyString("Enter room type to filter by: ");
                            var matches = rooms.Where(r => r.RoomType.Equals(type, StringComparison.OrdinalIgnoreCase))
                                                .ToList();
                            if (!matches.Any())
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                Console.WriteLine($"Rooms of type '{type}': {matches.Count}");
                                foreach (Room r in matches) r.DisplayRoom();
                            }
                            break;
                        }
                    case "3":
                        {
                            decimal maxPrice = ReadPositiveDecimal("Enter maximum price: ");
                            var matches = rooms.Where(r => r.IsAvailable && r.PricePerNight <= maxPrice)
                                                .OrderBy(r => r.PricePerNight)
                                                .ToList();
                            if (!matches.Any())
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                            }
                            else
                            {
                                Console.WriteLine($"Available rooms at or below OMR {maxPrice:F2}: {matches.Count}");
                                foreach (Room r in matches) r.DisplayRoom();
                            }
                            break;
                        }
                    case "4":
                        {
                            if (!rooms.Any())
                            {
                                Console.WriteLine("No rooms found for the selected criteria.");
                                break;
                            }
                            int total = rooms.Count();
                            int available = rooms.Count(r => r.IsAvailable);
                            decimal avg = rooms.Average(r => r.PricePerNight);
                            decimal min = rooms.Min(r => r.PricePerNight);
                            decimal max = rooms.Max(r => r.PricePerNight);

                            Console.WriteLine("Room Price Statistics:");
                            Console.WriteLine($"  Total rooms:      {total}");
                            Console.WriteLine($"  Available rooms:  {available}");
                            Console.WriteLine($"  Average price:    OMR {avg:F2}");
                            Console.WriteLine($"  Cheapest price:   OMR {min:F2}");
                            Console.WriteLine($"  Most expensive:   OMR {max:F2}");
                            break;
                        }
                    case "0":
                        inSubMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            }
        }


        // Case 07: Guest & Booking Statistics
        static void Case07_GuestBookingStatistics()
        {
            Console.WriteLine("--- Guest & Booking Statistics ---");

            int totalGuests = guests.Count();
            int guestsWithRoom = guests.Count(g => g.RoomNumber != Guest.NoRoomAssigned);
            int totalRooms = rooms.Count();
            int bookedRooms = rooms.Count(r => !r.IsAvailable);

            Console.WriteLine($"Total registered guests: {totalGuests}");
            Console.WriteLine($"Guests with a room assigned: {guestsWithRoom}");
            Console.WriteLine($"Total rooms: {totalRooms}");
            Console.WriteLine($"Booked rooms: {bookedRooms}");

            var activeGuests = guests.Where(g => g.RoomNumber != Guest.NoRoomAssigned).ToList();


            if (!activeGuests.Any())
            {
                Console.WriteLine("No active bookings recorded.");
                return;
            }

            double avgNights = activeGuests.Average(g => g.TotalNights);
            Console.WriteLine($"Average nights (active bookings): {avgNights:F2}");

            Console.WriteLine("\nTop 3 highest-spending guests:");
            var top3 = activeGuests
                .OrderByDescending(g => g.CalculateTotalCost(GetPriceForGuest(g)))
                .Take(3);
            foreach (Guest g in top3)
            {
                decimal cost = g.CalculateTotalCost(GetPriceForGuest(g));
                Console.WriteLine($"  {g.GuestName} - Room {g.RoomNumber} - OMR {cost:F2}");
            }


            Console.WriteLine("\nBooking summary:");
            var summaryLines = activeGuests.Select(g =>
                $"{g.GuestName} - Room {g.RoomNumber} - {g.TotalNights} nights - OMR {g.CalculateTotalCost(GetPriceForGuest(g)):F2}");
            foreach (string line in summaryLines)
            {
                Console.WriteLine($"  {line}");
            }
        }




    }
}