namespace DeliverySystem.Models
{
    public class Client
    {
        #region Поля и Свойства

        public Guid Id {get; init;}
        public string Name {get; private set;}
        public string Address {get; private set;}
        public string Email {get; private set;}
        public string PhoneNumber {get; init;} //todo Проверять парсинг по определённому формату
        public int CountSent {get; private set;}
        public int CountReceive {get; private set;}
        static int isCountObject = 0;

        #endregion

        #region Конструктор и методы

        public Client(Guid id, string name, string address, string email, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(paramName: nameof(name), message: "Вводимое значение является пустым или состоит из пустых символов.");

            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentNullException(paramName: nameof(address), message: "Вводимое значение является пустым или состоит из пустых символов.");

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentNullException(paramName: nameof(email), message: "Вводимое значение является пустым или состоит из пустых символов.");

            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentNullException(paramName: nameof(phoneNumber), message: "Вводимое значение является пустым или состоит из пустых символов.");

            Id = id;
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Client(string id, string name, string address, string email, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(paramName: nameof(name), message: "Вводимое значение является пустым или состоит из пустых символов.");

            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentNullException(paramName: nameof(address), message: "Вводимое значение является пустым или состоит из пустых символов.");

            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentNullException(paramName: nameof(email), message: "Вводимое значение является пустым или состоит из пустых символов.");

            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentNullException(paramName: nameof(phoneNumber), message: "Вводимое значение является пустым или состоит из пустых символов.");

            Id = Guid.Parse(id);
            Name = name;
            Address = address;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        static void CreateObject()
        {
            isCountObject ++;
        }

        #endregion
    }
}