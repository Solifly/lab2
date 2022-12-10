using Lab2.Accounts;
using Lab2.Main;
namespace Lab2.Games;

public abstract class Game
{
    private static readonly Random Rnd = new();
    protected readonly Account MyAccount;
    protected readonly Account OpponentAccount;
    protected static int GameId  = Rnd.Next(999);
    private readonly int[] _possibleRating = { 24, 26, 28, 30, 32 };
    public int Rating { get; set; }
    public virtual string Type => "ranked";

    protected Game(Account myAcc, Account otherAcc)
    {
        MyAccount = myAcc;
        OpponentAccount = otherAcc;
    }

    protected virtual int CalculateRating()
    {
        var randomRating = new Random();
        var index = randomRating.Next(0, _possibleRating.Length);
        return _possibleRating[index];
    }
    
    public virtual void GameStart()
    {
        var value = (GameResults.States)new Random().Next(2);
        Rating = CalculateRating();
        
        if (value == GameResults.States.Win)
        {
            MyAccount.WinGame(OpponentAccount.Username, GameId, this);
            OpponentAccount.LoseGame(MyAccount.Username, GameId, this);
            GameId++;
        }
        
        else if (value == GameResults.States.Lose)
        {
            MyAccount.LoseGame(OpponentAccount.Username, GameId, this);
            OpponentAccount.WinGame(MyAccount.Username, GameId, this);
            GameId++;
        }
    }
}