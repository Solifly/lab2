using Lab2.Games;

namespace Lab2.Accounts;

public class PremiumAccount : Account
{
    public PremiumAccount(string username, int currentRating) : base(username, currentRating) {}

    public override void LoseGame(string opponentName, int id, Game gameType)
    {
        gameType.Rating /= 2;
        base.LoseGame(opponentName, id, gameType);
    }
}