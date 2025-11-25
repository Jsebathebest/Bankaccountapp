using System;
using System.Collections.Generic;

namespace Bankaccountapp
{
    // Clase que representa un movimiento de cuenta
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string Type { get; set; } // "Deposit" o "Withdraw"
        public double Amount { get; set; }
        public double BalanceAfter { get; set; }

        public Transaction(DateTime date, string type, double amount, double balanceAfter)
        {
            Date = date;
            Type = type;
            Amount = amount;
            BalanceAfter = balanceAfter;
        }
    }

    public class AccountStatement
    {
        // Lista de movimientos de la cuenta
        private List<Transaction> transactions = new List<Transaction>();

        // Agregar un movimiento
        public void AddTransaction(string type, double amount, double currentBalance)
        {
            double newBalance = type == "Deposit" ? currentBalance + amount : currentBalance - amount;
            transactions.Add(new Transaction(DateTime.Now, type, amount, newBalance));
        }

        // Mostrar todos los movimientos
        public void PrintStatement()
        {
            Console.WriteLine("DATE\t\tTYPE\tAMOUNT\tBALANCE");
            foreach (var t in transactions)
            {
                Console.WriteLine($"{t.Date.ToShortDateString()}\t{t.Type}\t{t.Amount}\t{t.BalanceAfter}");
            }
        }

        // Obtener saldo actual
        public double GetCurrentBalance()
        {
            if (transactions.Count == 0) return 0;
            return transactions[transactions.Count - 1].BalanceAfter;
        }
    }
}
