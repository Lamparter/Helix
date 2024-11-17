using System.Xml.Linq;

namespace Helix
{
    /// <summary>
    /// Constructor for creating an instance of AnimalClassification
    /// </summary>
    /// <param name="commonName"></param>
    /// <param name="universalName"></param>
    /// <param name="life"></param>
    /// <param name="domain"></param>
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
    public class Linnaeus(string commonName, string universalName, string life, string domain, string kingdom, string phylum, string classClassification, string order, string family, string genus, string species, string? habitat = "", string? conservationStatus = "", string? description = "")
    {
        /// <summary>
        /// Common name of the animal
        /// </summary>
        public string CommonName { get; set; } = commonName;

        /// <summary>
        /// Scientific name of the animal
        /// </summary>
        public string UniversalName { get; set; } = universalName;

        /// <summary>
        /// Life classification
        /// </summary>
        public string Life { get; set; } = life;

        /// <summary>
        /// Domain classification
        /// </summary>
        public string Domain { get; set; } = domain;

        /// <summary>
        /// Kingdom classification
        /// </summary>
        public string Kingdom { get; set; } = kingdom;

        /// <summary>
        /// Phylum classification
        /// </summary>
        public string Phylum { get; set; } = phylum;

        /// <summary>
        /// Class classification
        /// </summary>
        public string Class { get; set; } = classClassification;

        /// <summary>
        /// Order classification
        /// </summary>
        public string Order { get; set; } = order;

        /// <summary>
        /// Family classification
        /// </summary>
        public string Family { get; set; } = family;

        /// <summary>
        /// Genus classification
        /// </summary>
        public string Genus { get; set; } = genus;

        /// <summary>
        /// Species classification
        /// </summary>
        public string Species { get; set; } = species;

        /// <summary>
        /// Habitat of the animal (nullable)
        /// </summary>
        public string? Habitat { get; set; } = habitat;

        /// <summary>
        /// Conservation status (e.g., Least Concern, Endangered)
        /// </summary>
        public string? ConservationStatus { get; set; } = conservationStatus;

        /// <summary>
        /// Description of the animal (nullable)
        /// </summary>
        public string? Description { get; set; } = description;

        public override string ToString()
        {
            return $"{CommonName} ({Species}) in {Habitat}";
        }

        public class AnimalDatabase
        {
            private List<Linnaeus> animals = [];

            public void AddAnimal(Linnaeus animal)
            {
                animals.Add(animal);
                Console.WriteLine($"Added animal: {animal}");
            }

            public Linnaeus GetAnimal(string name)
            {
                return animals.FirstOrDefault(a => a.CommonName == name);
            }
        }
    }
}
