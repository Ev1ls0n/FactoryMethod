using System;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Monsters
{
    /// <summary>
    /// Класс, который представляет объект зомби.
    /// </summary>
    class Zombie : IMonster
    {
        public string Name { get; } = "Зомби";

        public void Roar()
        {
            Console.WriteLine("Ар-х-х");
        }
    }
}
