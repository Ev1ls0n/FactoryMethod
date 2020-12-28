using FactoryMethod.Interfaces;
using FactoryMethod.Monsters;

namespace FactoryMethod.Spawners
{
    class SkeletonSpawner : ISpawner
    {
        public string Name { get; }

        public SkeletonSpawner(string name)
        {
            Name = name;
        }

        public IMonster Spawn()
        {
            return new Skeleton();
        }
    }
}
