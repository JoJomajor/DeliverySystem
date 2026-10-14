namespace DeliverySystem.Models
{
    public class Delivery
    {
        #region Поля и Свойства

        public Guid Id {get; init;}
        public string NameProduct {get; private set;}
        public int Count {get; private set;}
        public string UnitOfMeas {get; private set;} //* Единица измерения
        public float Cost {get; init;} 
        public int Currency {get; private set;} //* Валюта
        public string StartingAddress {get; init;} //todo Добавить парсинг по формату адреса
        public string EndingAddress {get; init; }
        //static int _isCountObject = 0;

        #endregion

        #region Конструкторы и методы

        public Delivery(Guid id, string nameProduct, int count, string unitOfMeas, float cost, int currency, string startingAddress, string endingAddress)
        {



            Id = id;
            NameProduct = nameProduct;
            Count = count;
            UnitOfMeas = unitOfMeas;
            Cost = cost;
            Currency = currency;
            StartingAddress = startingAddress;
            EndingAddress = endingAddress;
        }

        

        #endregion
    }
}