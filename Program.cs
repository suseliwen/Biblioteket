// Övning 1: Bibliotekssystem
/*Beskrivning: Skapa ett program som hanterar en enkel databas av böcker. Användaren ska kunna lägga till nya böcker, ta bort böcker och visa alla böcker som finns i biblioteket.

Instruktioner:

Skapa en klass Bok som har egenskaperna: Titel, Författare och ISBN.
Skapa en klass Bibliotek som hanterar en lista av böcker.
Programmet ska ha en meny där användaren kan:
Lägga till en bok genom att mata in titel, författare och ISBN.
Ta bort en bok baserat på ISBN.
Visa alla böcker i biblioteket.*/

class Programmet
{
    public static void Main()
    {
        bool isRunning = true;

        System.Console.WriteLine("Välkommen till programmet för hantering av biblioteksböcker");

        while (isRunning)
        {
            System.Console.WriteLine("*************************");
            System.Console.WriteLine("Gör ett av följande val: ");
            System.Console.WriteLine("*************************");

            System.Console.WriteLine("1. Lägg till en bok ");
            System.Console.WriteLine("2. Ta bort en bok ");
            System.Console.WriteLine("3. Visa samtliga böcker i biblioteket ");
            System.Console.WriteLine("4. Avsluta programmet ");
            System.Console.WriteLine();
            int input;
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                System.Console.WriteLine("Ogiltigt val. Försök igen!");
            }

            switch(input)
            {
                case 1:
                    System.Console.WriteLine("Det här är val nr 1 - lägg till en bok");
                    System.Console.WriteLine("");
                    break;
                
                case 2:
                    System.Console.WriteLine("Det här är val nr 2 - ta bort en bok");
                    System.Console.WriteLine("");
                    break;

                case 3:
                    System.Console.WriteLine("Det här är val nr 3 - skriv ut samtliga böcker i biblioteket");
                    System.Console.WriteLine("");
                    break;
                
                case 4:
                    isRunning = false;
                    System.Console.WriteLine("Tack för idag!");
                    System.Console.WriteLine("");
                    break;

                default:
                    System.Console.WriteLine("Ogiltigt val. Försök igen!");
                    break;

            }

        }


    }


}