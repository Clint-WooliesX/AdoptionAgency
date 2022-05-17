using System;
namespace AdoptionAgency
{
    public class AdoptionAgency
    {

        static public void Adopt(Person person, Animal animal)
        {

            if (person.Pet != null)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} already has a pet!!!", person.Name);
                Console.WriteLine();
                Console.ResetColor();
            }

            if (animal.Owner != null)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} already has a owner!!!", animal.Name);
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0} and {1} have been matched", person.Name , animal.Name);
                Console.WriteLine();
                Console.ResetColor();
                person.Pet = animal;
                animal.Owner = person;
            }
        }

        static public void Unadopt(Person person)
        {

            if (person.Pet != null)
            {
                person.Pet.Owner = null;
                person.Pet = null;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Pet and owner have been seperated!!!");
                Console.WriteLine();
                Console.ResetColor();
            }
        }

        static public void Unadopt(Animal animal)
        {

            if (animal.Owner != null)
            {
                animal.Owner.Pet = null;
                animal.Owner = null;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Pet and owner have been seperated!!!");
                Console.WriteLine();
                Console.ResetColor();
            }
        }

    }
}
