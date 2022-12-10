using Lab2.Accounts;
using Lab2.Main;
namespace Lab2.Games;

public class TitleMatch : Game //тип гри в якому лише один з учасників отримує рейтинг за перемогу
{
    public TitleMatch(Account myAcc, ChampionAccount champAcc) : base(myAcc, champAcc) {}
    public override string Type => "title";

    public override void GameStart()
    {
        var value = (GameResults.States)new Random().Next(2);
        Rating = CalculateRating();
        
        if (value == GameResults.States.Win)
        {
            OpponentAccount.LoseGame(MyAccount.Username, GameId, this);
            Rating = 0;
            MyAccount.WinGame(OpponentAccount.Username, GameId, this);
            GameId++;
        }
        
        else if (value == GameResults.States.Lose)
        {
            OpponentAccount.WinGame(MyAccount.Username, GameId, this);
            Rating = 0;
            MyAccount.LoseGame(OpponentAccount.Username, GameId, this);
            GameId++;
        }
    }
}