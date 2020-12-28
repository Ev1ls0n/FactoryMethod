namespace FactoryMethod.Interfaces
{
    /// <summary>
    /// Интерефейс представляющий спавнер.
    /// </summary>
    interface ISpawner
    {
        /// <summary>
        /// Название спавнера.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Метод, который создаёт монстра
        /// </summary>
        /// <returns></returns>
        IMonster Spawn();
    }
}
