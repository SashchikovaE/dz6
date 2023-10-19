using System;

namespace tumakov7
{
    enum Type
    {
        Current,
        Savings
    }
    class Bank
    {
        private long number;
        private double balance;
        private Type type;
        public void SetNumber(long number)
        {
            this.number = number;
        }
        public long GetNumber()
        {
            return number;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void SetType(Type type)
        {
            this.type = type;
        }
        public Type GetType(Type type)
        {
            return type;
        }
    }

    class Program
    {
        static long PrintArray(int[] numbers)
        {
            foreach (int i in numbers)
            {
                Console.Write("{0}", i);
            }
            return 0;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("упражнение 7.1");
            Bank bank = new Bank();
            bank.SetNumber(1234567890123456);
            bank.SetBalance(45376);
            bank.SetType(Type.Savings);
            Console.WriteLine("номер счета: " + bank.GetNumber());
            Console.WriteLine("баланс: " + bank.GetBalance());
            Console.WriteLine("тип банковского счета: " + bank.GetType());

            Console.WriteLine("упражнение 7.2");
            Random random = new Random();
            int[] numbers = new int[16];
                for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 9);
            }
            bank.SetNumber(PrintArray(numbers));

            Console.WriteLine("упражнение 7.3");
            Console.WriteLine("введите баланс");
            Console.WriteLine("введите сумму");
            double Balance = double.Parse(Console.ReadLine());
            double amount = double.Parse(Console.ReadLine());
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Списание {amount} успешно выполнено.\nНовый баланс: {Balance}");
            }
            else if (amount <= 0)
            {
                Console.WriteLine("Сумма для списания должна быть больше нуля.");
            }
            else
            {
                Console.WriteLine("Недостаточно средств на счете.");
            }
            Console.ReadKey();
        }
    }
}