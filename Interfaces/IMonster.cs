namespace FactoryMethod.Interfaces
{
    /// <summary>
    /// Интерфейс представляющий монстра.
    /// </summary>
    interface IMonster
    {
        /// <summary>
        /// Название монстра.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Метод, через который монстр издаёт свой клич.
        /// </summary>
        void Roar();
    }
}
