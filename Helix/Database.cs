﻿namespace Helix
{
    internal class Database
    {
        private List<Linnaeus> _animals = [];

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
