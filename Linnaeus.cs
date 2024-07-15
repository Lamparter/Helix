namespace Helix
{
    public class Linnaeus
    {
        // Common name of the animal
        public required string CommonName { get; set; }

        // Scientific name of the animal
        public required string ScientificName { get; set; }

        // Kingdom classification
        public required string Kingdom { get; set; }

        // Phylum classification
        public required string Phylum { get; set; }

        // Class classification
        public required string Class { get; set; }

        // Order classification
        public required string Order { get; set; }

        // Family classification
        public required string Family { get; set; }

        // Genus classification
        public required string Genus { get; set; }

        // Species classification
        public required string Species { get; set; }

        // Habitat of the animal
        public required string Habitat { get; set; }

        // Conservation status (e.g., Least Concern, Endangered)
        public required string ConservationStatus { get; set; }

        // Description of the animal (nullable)
        public string? Description { get; set; }

        // Constructor for creating an instance of AnimalClassification
        public void AnimalClass(string commonName, string scientificName, string kingdom, string phylum, string classClassification, string order, string family, string genus, string species, string habitat, string conservationStatus, string description)
        {
            CommonName = commonName;
            ScientificName = scientificName;
            Kingdom = kingdom;
            Phylum = phylum;
            Class = classClassification;
            Order = order;
            Family = family;
            Genus = genus;
            Species = species;
            Habitat = habitat;
            ConservationStatus = conservationStatus;
            Description = description;
        }

        // Method to display the classification of the animal
        public void DisplayClassification()
        {
            Console.WriteLine("Common Name: " + CommonName);
            Console.WriteLine("Scientific Name: " + ScientificName);
            Console.WriteLine("Kingdom: " + Kingdom);
            Console.WriteLine("Phylum: " + Phylum);
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("Order: " + Order);
            Console.WriteLine("Family: " + Family);
            Console.WriteLine("Genus: " + Genus);
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Habitat: " + Habitat);
            Console.WriteLine("Conservation Status: " + ConservationStatus);
            Console.WriteLine("Description: " + Description);
        }
    }
}
