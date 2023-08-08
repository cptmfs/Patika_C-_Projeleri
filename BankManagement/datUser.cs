using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class datUser
    {
        public object[,] datUsers = new object[,]
        {
            {"kbilisim", "cptmfs" },                       // Kullanıcı Adı  parametresi : userID
            {"1334","8008"},                               // Parola         parametresi : userPass
            {"Şirket Hesabı","Şahıs Hesabı"},              // Hesap Statüsü  parametresi : accountType
            {"22102014568","38674136732"},                 // Hesap No       parametresi : accountNumber
            {"4756 2184 3643 1501","3685 4540 2114 7836" },// Kart No        parametresi : cardNumber
            {"Kontrol Bilişim", "Muhammed Ferit Şimşek" },// Hesap  Adı     parametresi : userName
            {10000 , 3000 },

        };

    }
}
