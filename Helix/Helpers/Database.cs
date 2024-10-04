using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helix.Helpers
{
    internal class Database
    {
        private List<Linnaeus> _animals = new List<Linnaeus>();

        public void AddAnimal(Linnaeus animal)
        {
            _animals.Add(animal);
        }

        public void RemoveAnimal(Linnaeus animal)
        {
            _animals.Remove(animal);
        }

        public List<Linnaeus> GetAnimals()
        {
            return _animals;
        }
    }
}
