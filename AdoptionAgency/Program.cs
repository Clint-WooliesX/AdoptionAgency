using System;

namespace AdoptionAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create People looking to adopt //
            // takes one value "Name"
            Person Clint = new Person("Clint");
            Person Aidan = new Person("Aidan");

            // Create pets to adopt //
            //Takes 3 values "Species", "Name" and "Desexed" (true/false) //
            Animal Rex = new Animal("Dog", "Rex", true);
            Animal Felix = new Animal("Cat", "felix", false);


            // Animal Method to be adopted by a person//
            Rex.AdoptedBy(Aidan);
            Felix.AdoptedBy(Clint);

            // Person Method to display greeting //
            // Takes Bool to display Object variables in color //
            Clint.Gretting(true);
            Aidan.Gretting();

            Rex.AnimalData();
            Felix.AnimalData();

        }
    }
}

