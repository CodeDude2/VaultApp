using System;
using Avalonia.Interactivity;

namespace Vault.Views;

using Avalonia.Controls;

public partial class CreateAccount : UserControl
{
    public CreateAccount()
    {
        InitializeComponent();
    }

    private void SubmitInfo(object? sender, RoutedEventArgs e)
    {
        string username = Username.Text ?? "";
        string password = Password.Text ?? "";
        
    }
    
}