/*using System;
using System.Globalization;

namespace Course1 {
    class Program {
        static void Main(string[] args) {

            RentedRooms[] vect = new RentedRooms[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();


            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                vect[room] = new RentedRooms(name, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 1; i <= 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);


                }
            }
        }
    }
}
*/