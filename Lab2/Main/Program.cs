using Lab2.Accounts;
namespace Lab2.Main;

internal static class Program
{
    private static void Main()
    {
        Console.WriteLine("Game Started!");
        
        DefaultAccount myAccount = new DefaultAccount("Vadim", 220);
        PremiumAccount premAccount = new PremiumAccount("Maxim", 240);
        ChampionAccount champAccount = new ChampionAccount("Kirill", 220);

        GameManager.StartRanked(myAccount, premAccount, 3);
        GameManager.StartTitleMatch(myAccount, champAccount, 4);
        GameManager.StartUnranked(myAccount, premAccount, 2);

        Console.WriteLine("----------------------------------------------Your Career--------------------------------------------");
        myAccount.GetStats();
        
        Console.WriteLine("--------------------------------------------Kirill's Career-------------------------------------------");
        premAccount.GetStats();
        
        Console.WriteLine("--------------------------------------------Maxim's Career--------------------------------------------");
        champAccount.GetStats();
    }
}