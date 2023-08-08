using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class BankManager
    {
        public static string accountType, accountNumber, cardNumber, userId, userPass, userName;
        public static int balance;
        public static bool MainMenu()
        {
            Console.Clear();
            bool showLogin = true;


            Console.WriteLine("\t\t\t\t\t\t ------ UCC Bank'a Hoşgeldiniz ------");
            Console.WriteLine("1. Sistem Giriş");
            Console.WriteLine("2. Programdan Çıkış");
            Console.Write("\nSeçeneğiniz : ");

            switch (Console.ReadLine())
            {


                case "1":
                    while (showLogin)
                    {
                        showLogin = LoginMenu();
                    }

                    return true;

                case "2":
                    // Programdan Çıkış ekranı..

                    return false;

                default:
                    return true;
            }
        }



        public static bool LoginMenu()
        {
            AccountManager accountManager = new AccountManager();
            Console.Clear();

            bool login = false;
            Console.WriteLine("\t\t\t\t\t\t ------ Müşteri Giriş Ekranı ------\n\n\n");
            Console.WriteLine("Ana Menüye dönmek için * a basınız ..\n");
            Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz : ");
            userId = Console.ReadLine().Trim();

            if (userId == "*")
            {
                return false;
            }
            datUser dat = new datUser();
            Console.WriteLine("Lütfen şifrenizi giriniiz : ");
            userPass = Console.ReadLine();
            userPass = userPass.Trim();
            if (UserContorl(dat.datUsers, userId, userPass))
            {
                Console.WriteLine("Kullanıcı Girişi Başarılıdır.. \n\n");
                Console.WriteLine($"Giriş Yapan Kullanıcı : {userId}\t Hesap Statüsü :{accountType}");
                login = true;
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya Şifreniz hatalı.!!\nTekrar denemek için herhangi bir tuşa basınız...");
                Console.ReadKey();
                return false;
            }

            return BankAccount(accountManager);
        }

        public static bool UserContorl(object[,] _datUsers, string _user, string _pass)
        {

            bool found = false;
            for (int satir = 0; satir < _datUsers.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < _datUsers.GetLength(1); sutun++)
                {
                    if ((string)_datUsers[satir, sutun] == _user) // Kullanıcı adı listede yada veritabanında varmı ? 
                    {
                        if ((string)_datUsers[satir + 1, sutun] == _pass) // varsa şifresi kullanıcı adi ile uyusuyormu ? 
                        {
                            accountType = (string)_datUsers[satir + 2, sutun]; //uyuştu ise kullanıcı hesap türü listeden al..
                            accountNumber = (string)_datUsers[satir + 3, sutun]; // Kullanıcı Hesap No listeden al..
                            cardNumber = (string)_datUsers[satir + 4, sutun]; // Kullanıcı Kart No listeden al..
                            userName = (string)_datUsers[satir + 5, sutun]; // Kullanıcı Adını  listeden al..
                            balance = (int)_datUsers[satir + 6, sutun]; // Hesap Bakiyesi Öğrenme
                            found = true;   // Kullanıcı bulundu
                            break;
                        }
                    }
                }
                if (found == true)
                {
                    break;
                }
                if (satir == 2)
                {
                    break;
                }
            }
            return found;

        }

        public static bool BankAccount(AccountManager accountManager)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t ------ Hesap İşlemleri Menüsü ------\n\n\n");
            Console.WriteLine("Lütfen Aşağıdaki Menüden Yapmak istediğiniz İşlemi Seçiniz..");
            Console.WriteLine("1. Hesap Özeti ");
            Console.WriteLine("2. Para Yatırma ");
            Console.WriteLine("3. Para Çekme ");
            Console.WriteLine("4. Menüden Çıkış");
            Console.WriteLine("Lütfen bir menü seçiniz   :   ");

            switch (Console.ReadLine())
            {
                case "1":
                    accountManager.Bankstatement();
                    return BankAccount(accountManager);
                case "2":
                    accountManager.Deposit(accountManager);
                    return BankAccount(accountManager);
                case "3":
                    accountManager.Withdraw(accountManager);
                    return BankAccount(accountManager);
                case "4":
                    // Menüden Çıkış..
                    return false;
                default:
                    return true;
            }

        }


    }
}
