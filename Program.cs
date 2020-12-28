using System;
using System.Collections.Generic;

using FactoryMethod.Spawners;
using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IMonster> monsters = new List<IMonster>();

            ZombieSpawner zombieSpawner1 = new ZombieSpawner("Спавнер зомби");
            SkeletonSpawner skeletonSpawner1 = new SkeletonSpawner("Спавнер скелетов");

            for (int i = 0; i < 5; i++)
            {
                monsters.Add(zombieSpawner1.Spawn());
                monsters.Add(skeletonSpawner1.Spawn());
            }

            Console.WriteLine($"Кол-во монстров: {monsters.Count}");

            foreach (var m in monsters)
            {
                Console.WriteLine($"Монстр {m.Name} издаёт клич:");
                m.Roar();
            }

            Console.ReadKey();
        }
    }
}
