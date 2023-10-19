using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    public class MobileOperators
    {
        enum RateMts
        {
            simply,
            more,
            super
        }
        enum RateTele2
        {
            lala,
            fff
        }
        enum RateBeeline
        {
            kaka,
            yaya
        }
        public string name { get; set; }
    }
    public class Subscriber : MobileOperators
    {
        public string namee;
        public long numberOfTelephone;
        public string mobileOperator;
        public Subscriber(string namee, long numberOfTelephone, string mobileOperator)
        {
            this.namee = namee;
            this.numberOfTelephone = numberOfTelephone;
            this.mobileOperator = mobileOperator;
        }
        public Subscriber() { }
        static Subscriber RegisterUser()
        {
            Console.WriteLine("введите имя пользователя");
            string namee = Console.ReadLine();
            Console.WriteLine("введите номер телефон");
            long numberOfTelephone = long.Parse(Console.ReadLine());
            Console.WriteLine("введите мобильного оператора, которым вы хотите пользоваться");
            string mobileOperatorr = Console.ReadLine();
            Subscriber subscriber = new Subscriber(namee, numberOfTelephone, mobileOperatorr);
            Console.WriteLine("пользователь успешно зарегистрирован!");
            return subscriber;
        }
        public double Balance { get; set; }

        public void ToUpBalance(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("некорректная сумма пополнения!");
                return;
            }
            Console.WriteLine($"пополнение баланса на {amount} рублей. текущий баланс: {Balance} рублей");
            Balance += amount;
            Console.WriteLine($"баланс успешно пополнен. новый баланс: {Balance} рублей");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Subscriber subscriber = new Subscriber();
            Console.WriteLine("введите сумму пополнения счёта");
            double a = double.Parse(Console.ReadLine());
            subscriber.ToUpBalance(a);
            Console.ReadKey();
        }
    }
}