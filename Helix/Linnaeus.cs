namespace Helix
{
    public class Linnaeus
    {
        /// <summary>
        /// Common name of the animal
        /// </summary>
        public string CommonName { get; set; }

        /// <summary>
        /// Scientific name of the animal
        /// </summary>
        public required string UniversalName { get; set; }

        /// <summary>
        /// Kingdom classification
        /// </summary>
        public required string Kingdom { get; set; }

        /// <summary>
        /// Phylum classification
        /// </summary>
        public required string Phylum { get; set; }

        /// <summary>
        /// Class classification
        /// </summary>
        public required string Class { get; set; }

        /// <summary>
        /// Order classification
        /// </summary>
        public required string Order { get; set; }

        /// <summary>
        /// Family classification
        /// </summary>
        public required string Family { get; set; }

        /// <summary>
        /// Genus classification
        /// </summary>
        public required string Genus { get; set; }

        /// <summary>
        /// Species classification
        /// </summary>
        public required string Species { get; set; }

        /// <summary>
        /// Habitat of the animal (nullable)
        /// </summary>
        public string? Habitat { get; set; }

        /// <summary>
        /// Conservation status (e.g., Least Concern, Endangered)
        /// </summary>
        public required string ConservationStatus { get; set; }

        /// <summary>
        /// Description of the animal (nullable)
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Constructor for creating an instance of AnimalClassification
        /// </summary>
        /// <param name="commonName"></param>
        /// <param name="universalName"></param>
        /// <param name="kingdom"></param>
        /// <param name="phylum"></param>
        /// <param name="classClassification"></param>
        /// <param name="order"></param>
        /// <param name="family"></param>
        /// <param name="genus"></param>
        /// <param name="species"></param>
        /// <param name="habitat"></param>
        /// <param name="conservationStatus"></param>
        /// <param name="description"></param>
        public Linnaeus(string commonName, string universalName, string kingdom, string phylum, string classClassification, string order, string family, string genus, string species, string? habitat, string conservationStatus, string? description)
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
