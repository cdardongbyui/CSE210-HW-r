using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressLecture = new Address("C.C. Fontabella, Sophos Bookstore", "Guatemala", "Guatemala", "Guatemala");
        Address addressReception = new Address("Bonanza, La Ponderosa", "Tecpán", "Chimaltenango", "Guatemala");
        Address addressOutdoor = new Address("La Reforma Avenue, Casa Ariana", "Guatemala", "Guatemala", "Guatemala");

        Lecture lectureEvent = new Lecture("Literary Reading: 'Harry Potter'", "A Magic Festival at Hogwarts", "October 31, 2023", "7 PM", addressLecture, "Albus Dumbledore", 120);
        Reception receptionEvent = new Reception("Dardón spouses Reception", "Face to face with GOD", "August 18, 2023", "9 PM", addressReception, "services@laponderosa.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Cosplay Convention", "ComiCON", "September 16, 2023", "3 PM", addressOutdoor, "sunny");
        Console.WriteLine();

        Console.WriteLine("Lecture Event:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.GenerateStandard());
        Console.WriteLine("Full Details:");
        Console.WriteLine(lectureEvent.GenerateDetailedLecture());
        Console.WriteLine("Short Description:");
        Console.WriteLine(lectureEvent.GenerateShortLecture());
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(receptionEvent.GenerateStandard());
        Console.WriteLine("Full Details:");
        Console.WriteLine(receptionEvent.GenerateDetailedReception());
        Console.WriteLine("Short Description:");
        Console.WriteLine(receptionEvent.GenerateShortReception());
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Outdoor Event:");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorGathering.GenerateStandard());
        Console.WriteLine("Full Details:");
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
        Console.WriteLine();
        Console.WriteLine();
    }
}
