using Lab2.Accounts;
namespace Lab2.Games;

public class Ranked : Game //тип гри в якому обидва учасники можуть отримати та втратити рейтинг
{
    public Ranked(Account myAcc, Account otherAcc) : base(myAcc, otherAcc) {}
}