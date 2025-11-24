using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bankaccountapp
{
    public class BankAccount

    {
        public  string Owner { get; set; }
        public Guid AccountNumber { get; set; }

        public decimal Balance { get; private set; }

        public BankAccount(string owner) 
        {

            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
             
        }

        public string deposit(decimal amount)

        {
            if (amount <= 0)
            {
                return " El valor a depositar debe ser mayor a $" + amount;
            }

            else if (amount > 500000)
            {


                return " Mucho para deositar por aqui ";

            }
            else 
            
            {
            Balance += amount;
                return " Deposito exitoso";
            
            }


            
        
        }

        public string Withdraw (decimal amount)
        {
            if (amount <= 0)
            {


                return " No puedes retirar" + amount;
            }
            else if (amount > Balance)


            {
                return " No se puede eso es tigueraje";

            }
            else {


                Balance -= amount;
                
                return " Retiro exitoso";

            }


        }
    }
}
