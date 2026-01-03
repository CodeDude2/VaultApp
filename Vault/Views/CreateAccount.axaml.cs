using System;
using Avalonia.Interactivity;
using Vault.ViewModel;

namespace Vault.Views;

using Avalonia.Controls;

public partial class CreateAccount : UserControl
{
    public CreateAccount()
    {
        InitializeComponent();
    }

    public void SubmitInfo(object? sender, RoutedEventArgs e)
    {
        string firstName = FirstName.Text ?? "";
        string lastName = LastName.Text ?? "";
        string username = Username.Text ?? "";
        string password = Password.Text ?? "";
        
        Account newAccount = new Account(username, password, firstName, lastName);
    }
    

}