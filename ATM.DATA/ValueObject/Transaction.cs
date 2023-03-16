using System;


namespace ATM.DATA.ValueObject
{
    public class Transaction
    {
        public long Amount { get; }
        public DateTime Date { get; }
        public string Type { get; }
        public string Description { get; }
        public int Account { get; } 

        public Transaction(long amount, string type, string description, DateTime date)
        {
            Amount = amount;
            Date = date;
            Type = type;
            Description = description;
        }
        public Transaction(long amount, int account, string type, string description, DateTime date)
        {
            Amount = amount;
            Account = account;
            Date = date;
            Type = type;
            Description = description;
        }
    }
}
