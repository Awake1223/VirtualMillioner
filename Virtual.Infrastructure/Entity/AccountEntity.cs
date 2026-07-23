

namespace Virtual.Infrastructure.Entity
{
    public class AccountEntity
    {
        public Guid id { get; set; }

        //Связь с пользователем
        public Guid UserId {  get; set; }
        public MillionerUserEntity User { get; set; } = null;

        //Метаданные
        public string AccountNumber { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdatedAt { get; set;} = DateTime.UtcNow;

        //Денежные поля
        public string Currency { get; set; } = "USD"; //USD, EUR, RUB, BTC
        public decimal Balance { get; set; } = 0;
        public decimal FrozenBalance { get; set; } = 0;
    }
}
