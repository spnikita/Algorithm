namespace Algorithm
{
    /// <summary>
    /// Пользователь
    /// </summary>
    internal class User
    {
        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }
        
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Имеется премиум подписка, да/нет
        /// </summary>
        public bool IsPremium { get; set; }
    }
}
