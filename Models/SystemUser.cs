namespace DeliverySystem.Models
{
    public record SystemUser
    {
        #region Поля и Свойства

        public Guid Id {get; init;}
        public string Login {get; init;}
        public string Password {get; init;}

        #endregion
    
        #region Конструктор и методы
        public SystemUser(Guid id, string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentNullException(paramName: login, message: "Вводимое значение является пустым или состоит из пустых символов.");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException(paramName: login, message: "Вводимое значение является пустым или состоит из пустых символов.");

            Id = id;
            Login = login;
            Password = password;
        }

        #endregion
    }
}