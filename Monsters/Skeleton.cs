using System;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Monsters
{
    /// <summary>
    /// Класс, который представляет объект скелета.
    /// </summary>
    class Skeleton : IMonster
    {
        public string Name { get; } = "Скелет";

        public void Roar()
        {
            Console.WriteLine("*Шум костей*");
        }
    }
}
