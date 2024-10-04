namespace Helix
{
    public class Linnaeus
    {
        // Common name of the animal
        public string? CommonName { get; set; }

        // Scientific name of the animal
        public required string UniversalName { get; set; }

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

        // Habitat of the animal (nullable)
        public string? Habitat { get; set; }

        // Conservation status (e.g., Least Concern, Endangered)
        public required string ConservationStatus { get; set; }

        // Description of the animal (nullable)
        public string? Description { get; set; }

        // Constructor for creating an instance of AnimalClassification
        public Linnaeus(string? commonName, string universalName, string kingdom, string phylum, string classClassification, string order, string family, string genus, string species, string? habitat, string conservationStatus, string? description)
        {
            this.CommonName = commonName;
            this.UniversalName = universalName;
            this.Kingdom = kingdom;
            this.Phylum = phylum;
            this.Class = classClassification;
            this.Order = order;
            this.Family = family;
            this.Genus = genus;
            this.Species = species;
            this.Habitat = habitat;
            this.ConservationStatus = conservationStatus;
            this.Description = description;
        }
    }
}
