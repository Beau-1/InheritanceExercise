using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - Done
            // give this class 4 members that all Animals have in common -Done


            // Create a class Bird -Done
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile -Done
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird Ostrich = new Bird();

            Ostrich.Beaked = true;
            Ostrich.Egglaying = true;
            Ostrich.Feathered = true;

            Console.WriteLine($"The ostrich has a beak? Answer:{Ostrich.Beaked}");
            Console.WriteLine($"The ostrich lays eggs? Answer:{Ostrich.Egglaying}");
            Console.WriteLine($"The ostrich is feathered? Answer:{Ostrich.Feathered}");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptiles KomodoDragon = new Reptiles();

            KomodoDragon.Scaled = true;
            KomodoDragon.Venomus = true;
            KomodoDragon.Coldblooded = true;

            Console.WriteLine($"Komodo Dragons have scales? Answer:{KomodoDragon.Scaled}");
            Console.WriteLine($"Komodo Dragons are venomus? Answer:{KomodoDragon.Venomus}");
            Console.WriteLine($"Komodo Dragons are cold-blooded? Answer:{KomodoDragon.Coldblooded}");

        }
    }
}
