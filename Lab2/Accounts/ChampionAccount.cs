using Lab2.Games;
namespace Lab2.Accounts;

public class ChampionAccount : Account
{
    public ChampionAccount(string username, int currentRating) : base(username, currentRating) {}
    private static int _winsInARow;

    public override void WinGame(string opponentName, int id, Game gameType)
    {
        _winsInARow++;
        if (_winsInARow > 3)
        {
            gameType.Rating *= 3;
            _winsInARow = 0;
        }
        base.WinGame(opponentName, id, gameType);
    }

    public override void LoseGame(string opponentName, int id, Game gameType)
    {
        _winsInARow = 0;
        base.LoseGame(opponentName, id, gameType);
    }
}