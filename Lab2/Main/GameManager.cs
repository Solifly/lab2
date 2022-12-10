using Lab2.Accounts;
using Lab2.Games;
namespace Lab2.Main;

public static class GameManager
{
    public static void StartRanked(Account firstAccount, Account secondAccount, int times)
    {
        Ranked ranked = new Ranked(firstAccount, secondAccount);
        for (int i = 0; i <= times; i++)
        {
            ranked.GameStart();
        }
    }
    
    public static void StartUnranked(Account firstAccount, Account secondAccount, int times)
    {
        Unranked unranked = new Unranked(firstAccount, secondAccount);
        for (int i = 0; i <= times; i++)
        {
            unranked.GameStart();
        }
    }
    
    public static void StartTitleMatch(Account challengerAccount, ChampionAccount champAccount, int times)
    {
        TitleMatch titleMatch = new TitleMatch(challengerAccount, champAccount);
        for (int i = 0; i <= times; i++)
        {
            titleMatch.GameStart();
        }
    }
}