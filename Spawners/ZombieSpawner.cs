using FactoryMethod.Interfaces;
using FactoryMethod.Monsters;

namespace FactoryMethod.Spawners
{
    class ZombieSpawner : ISpawner
    {
        public string Name { get; }

        public ZombieSpawner(string name)
        {
            Name = name;
        }

        public IMonster Spawn()
        {
            return new Zombie();
        }
    }
}
