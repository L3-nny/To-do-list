using System;

public class UserAccount
{
    public string Username { get; set; }

    public string Password { private get; set; }

    public UserAccount(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public bool VerifyPassword(string input)
    {
        return Password == input;
    }
}

class Program
{
    static void Main()
    {
        UserAccount account = new UserAccount("lennymubea", "Lenny2025");

        Console.WriteLine("Username: " + account.Username);

        bool correct = account.VerifyPassword("Lenny2005");
        Console.WriteLine("Password: " + correct);

        bool wrong = account.VerifyPassword("joemama1");
        Console.WriteLine("Password: " + wrong);

        account.Password = "joemama1";
        bool status = account.VerifyPassword("joemama1");
        Console.WriteLine("Password: " + status);
        
    }
}