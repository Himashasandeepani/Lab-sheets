using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_sheet2_Q2_
{
    public class BankAccount
    {
        public int AccountNumber;
        public Double Balance;

        //create a constructor.
        /*
        public BankAccount(double InitialBalance)
        {
            Balance = InitialBalance;
        }
        */
        public void deposite(double amount)
        {
            //updating balance
            Balance += amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //if use constructor  initialized values.
            // BankAccount account = new BankAccount(1000);
            BankAccount account = new BankAccount();


            Console.Write("Enter the account number : ");
            account.AccountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the deposite amount : ");
            double amount = double.Parse(Console.ReadLine());

            account.deposite(amount);

            Console.WriteLine("Account number : " +account.AccountNumber);
            Console.WriteLine("Update balance : " + account.Balance);

            Console.ReadLine();

        }
    }
}
