using Lab2.Accounts;
namespace Lab2.Games;

public class Unranked : Game //тип гри в якому неможливо отримати чи втратити рейтинг
{
    public Unranked(Account myAcc, Account otherAcc) : base(myAcc, otherAcc) {}
    public override string Type => "trainy";

    protected override int CalculateRating()
    {
        return 0;
    }
}