using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using пр13._2;

namespace пр13._2
{
    class BankAccount
    {
        public string Owner { get; set; }
        public long Account { get; set; }
        public int Balance { get; set; }

        public BankAccount(string owner, long account, int balance)
        {
            Owner = owner;
            Account = account;
            Balance = balance;
        }
        public void Info()
        {
            Console.WriteLine($"Владелец: {Owner}, номер счета: {Account}, баланс: {Balance}");
        }
    }
    class CheckingAccount : BankAccount
    {
        public double Checking { get; set; }
        public CheckingAccount(string owner, long account, int balance, double checking) : base("", account, balance)
        {
            Checking = checking;
        }
        public void Info1() { Console.WriteLine($"Текущий баланс с лимитом овердрафта: {Checking}"); }
    }
    class SavingsAccount : BankAccount
    {
        public double Savings { get; set; }
        public double Percent { get; set; }
        public SavingsAccount(string owner, long account, int balance, double saving, double percent) : base("", account, balance)
        {
            Savings = saving;
            Percent = percent;
        }
        public void Info2()
        {
            Console.WriteLine($"Сберегательный счет с процентной ставкой: {Savings}, {Percent}");
        }
    }
    class CreditAccount : BankAccount
    {
        public double Credit { get; set; }
        public int Data { get; set; }
        public CreditAccount(string owner, long account, int balance, double credit, int data) : base("", account, balance)
        {
            Credit = credit;
            Data = data;
        }
        public void Info3() { Console.WriteLine($"Кредитный счет с кредитным лимитом и сроком: {Credit} и сроком {Data} "); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Маргаритта",7428_3920_9573_2983, 135000);
            bankAccount.Info();
            CheckingAccount checkingAccount = new CheckingAccount("Маргаритта", 7428_3920_9573_2983, 135000, 150000);
            checkingAccount.Info1();
            SavingsAccount savingsAccount = new SavingsAccount("Маргаритта", 7428_3920_9573_2983, 130000, 200000, 5.5);
            savingsAccount.Info2();
            CreditAccount creditAccount = new CreditAccount("Маргаритта", 7428_3920_9573_2983, 135000, 50000, 36);
            creditAccount.Info3();
        }

    }
}






