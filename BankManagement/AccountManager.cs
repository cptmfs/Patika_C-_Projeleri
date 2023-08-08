using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class AccountManager : BankManager
    {
        string backMenu;

        public bool Bankstatement()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t ------ Hesap Özeti  ------\n\n\n");
            Console.WriteLine($"Hesap Sahibi   : {userName}");
            Console.WriteLine($"Hesap Statüsü  : {accountType}");
            Console.WriteLine($"Hesap Numarası : {accountNumber}");
            Console.WriteLine($"Kart Numarası  : {cardNumber}");
            Console.WriteLine($"Hesap Bakiyesi : {balance} Euro ");
            Console.WriteLine("\nBir Üst Menüye Dönmek için Herhangi bir Tuşa Basınız");
            Console.ReadKey();

            return true;

        }

        public bool Deposit(AccountManager accountManager)
        {
            int tlAmount, euAmount;
            Console.WriteLine($"Hesap Bakiyesi :{balance} Euro ");

            Console.WriteLine("Lütfen Yatırmak İstediğiniz Para Miktarınız Giriniz : ");
            tlAmount = int.Parse(Console.ReadLine());
            euAmount = tlAmount / 20;

            balance += euAmount;

            Console.WriteLine($"Yeni Hesap Bakiyeniz : {balance} Euro ");
            Console.WriteLine("\nBir Üst Menüye Dönmek için Herhangi bir Tuşa Basınız");
            Console.ReadKey();

            return true;
        }
        public bool Withdraw(AccountManager accountManager)
        {
            int tlAmount, euAmount;
            Console.WriteLine($"Hesap Bakiyesi :{balance} Euro ");

            Console.WriteLine("Lütfen Çekmek İstediğiniz Para Miktarınız Giriniz : ");
            tlAmount = int.Parse(Console.ReadLine());
            euAmount = tlAmount / 20;
            if (balance >= euAmount)
            {
                balance -= euAmount;
                Console.WriteLine($"Yeni Hesap Bakiyeniz : {balance} Euro ");
            }
            else
            {
                Console.WriteLine("Hesap Bakiyesi Yetersiz..");
            }

            Console.WriteLine("\nBir Üst Menüye Dönmek için Herhangi bir Tuşa Basınız");
            Console.ReadKey();

            return true;
        }




    }
}
