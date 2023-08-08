using BankManagement;

internal class Program : BankManager
{
    private static void Main(string[] args)
    {
        bool showMenu = true;

        while (showMenu)
        {
            showMenu = MainMenu();
        }

        Console.WriteLine("Çıkış İçin herhangi Bir Tuşa Basınız...");



        Console.ReadKey();
    }
}