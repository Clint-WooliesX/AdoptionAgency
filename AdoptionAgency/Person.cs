using System;
namespace AdoptionAgency
{
    public class Person
    {
        public string Name;
        public Animal Pet;


        public Person(string name)
        {
            Name = name;
        }

        public void PersonData()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Pet: {0}", Pet);

        }

        public void Gretting(bool color = false)
        {
            if (!color)
            {
                Console.WriteLine("Hi my name is {0} and I addopted a {1} named {2}", Name, Pet.Species, Pet.Name);
                Console.WriteLine();
            }
            else
            // if TRUE prints the above line with the Variables colored Yellow
            {
                Console.Write("Hi my name is ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("{0} ", Name);
                Console.ResetColor();
                Console.Write("and I addopted a ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("{0} ", Pet.Species);
                Console.ResetColor();
                Console.Write("named ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("{0} ", Pet.Name);
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}
