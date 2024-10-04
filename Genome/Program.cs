namespace Helix.Genome
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals animals = new Animals();

            // Example of adding instances of Animal
            animals.AnimalList.Add(new Linnaeus
            {
                CommonName = "Lion",
                UniversalName = "Panthera leo",
                Kingdom = "Animalia",
                Phylum = "Chordata",
                Class = "Mammalia",
                Order = "Carnivora",
                Family = "Felidae",
                Genus = "Panthera",
                Species = "P. leo",
                Habitat = "Savannah",
                ConservationStatus = "Vulnerable",
                Description = "Large carnivorous feline of Africa and India"
            });

            animals.AnimalList.Add(new Linnaeus
            {
                CommonName = "Tiger",
                UniversalName = "Panthera tigris",
                Kingdom = "Animalia",
                Phylum = "Chordata",
                Class = "Mammalia",
                Order = "Carnivora",
                Family = "Felidae",
                Genus = "Panthera",
                Species = "P. tigris",
                Habitat = "Forest",
                ConservationStatus = "Endangered",
                Description = "The largest cat species, most recognizable for its pattern of dark vertical stripes"
            });

            // Add more animals as needed

            Console.WriteLine("Animals added successfully!");
            Console.ReadLine();
        }
    }
}
