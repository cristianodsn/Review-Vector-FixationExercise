using System;
using System.Globalization;
using Rascunho.Entities;

class Program
{
    static void Main(string[] args)
    {
        int totalBedRooms = 10;
        Student[] dedRooms = new Student[totalBedRooms];

        Console.Write("Enter the quantity of students: ");
        int quantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Insert student data: ");
        for (int i = 0; i < quantity; i++)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Roon number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            dedRooms[roomNumber] = new Student { Name = name, Email = email, Room = roomNumber };
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("LODGING MANAGEMENT");
        Console.WriteLine("Occupied lodgings: ");
        
        for(int i = 0; i< dedRooms.Length; i++)
        {
            if (dedRooms[i] != null)
            {
                Console.WriteLine(dedRooms[i]);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Vacant lodgings");
        for (int i = 0; i < dedRooms.Length; i++)
        {
            if (dedRooms[i] == null)
            {
                Console.WriteLine("Room number:" + i);
            }
        }

        Console.ReadKey();
    }
}
