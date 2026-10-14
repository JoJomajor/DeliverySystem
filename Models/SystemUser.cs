namespace DeliverySystem.Models
{
    public record SystemUser
    {
        #region Поля и Свойства

        public Guid Id {get; init;}
        public string Login {get; init;} = string.Empty;
        public string Password {get; init;} = string.Empty;

        #endregion
    
    }
}