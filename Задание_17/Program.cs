using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_17
{
    class Program
    {
        /*Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
        Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета.
        Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. Создать  несколько экземпляров класса, параметризированного различными типами.
        Заполнить его поля и вывести информацию об экземпляре класса на печать.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ФИО:");
            string fullName1 = Console.ReadLine();
            Console.WriteLine("Введите номер счета в виде числа:");
            int accountNumber1 = Convert.ToInt32(Console.ReadLine());
            Random random1 = new Random ();
            int accountBalance1 = random1.Next(0,1000000);
            BankAccount<int> bankAccount1 = new BankAccount<int>(accountNumber1, accountBalance1, fullName1);
            bankAccount1.Print();
            Console.WriteLine();
            Console.WriteLine("Введите ФИО:");
            string fullName2 = Console.ReadLine();
            Console.WriteLine("Введите номер счета в виде строки:");
            string accountNumber2 = Console.ReadLine();
            Random random2 = new Random();
            int accountBalance2 = random2.Next(0, 1000000);
            BankAccount<string> bankAccount2 = new BankAccount<string>(accountNumber2, accountBalance2, fullName2);
            bankAccount2.Print();
            Console.ReadKey();
        }
    }
    class BankAccount<T>
    {
        private T AccountNumber { get; set; }
        private int AccountBalance { get; set; }
        private string FullName { get; set; }
        public BankAccount(T accountNumber, int accauntBalance, string fullName)
        {
            AccountNumber = accountNumber;
            AccountBalance = accauntBalance;
            FullName = fullName;
        }
        public void Print()
        {
            Console.WriteLine("Информация по счету:\nВладелец: {0}\nНомер счета: {1}\nНа вашем счету: {2} $", FullName, AccountNumber, AccountBalance);
        }
    }
}
