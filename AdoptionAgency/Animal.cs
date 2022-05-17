using System;

namespace AdoptionAgency
{
    public class Animal
    {
        public string Name;
        public string Species;
        public Person Owner;
        public bool Desexed;


        public Animal( string species, string name, bool desexed)
        {
            Species = species;
            Name = name;
            Desexed = desexed;
        }

        public void AnimalData()
        {
            Console.WriteLine("Species: {0}", Species);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Desexed: {0}", Desexed);
            Console.WriteLine();
        }

        public void AdoptedBy(Person name)
        { 
            name.Pet = this;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Species: " + Species;
        }
    }

}
