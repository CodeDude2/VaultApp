using System;

namespace Vault.ViewModel;

public class Account
{
    private string _FirstName { get; }
    private string _LastName { get; }
    private string _Username { get; }
    private string _Password { get; }

    public Account(string username, string password,string firstName, string lastName)
    {
        _FirstName = firstName;
        _LastName = lastName;
        _Username = username;
        _Password = password;
        
        Console.WriteLine(_FirstName);
        Console.WriteLine(_LastName);
        Console.WriteLine(_Username);
        Console.WriteLine(_Password);
    }
    
}