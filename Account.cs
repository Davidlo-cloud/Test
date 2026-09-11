namespace simpleGit;

public class Account
{
    public int Balance { get; set; }
    public string AccountNumber { get; set; } = "";

    public void Deposit(int amount)
    {
        System.Console.WriteLine("Nisse was here!");
    }
}
