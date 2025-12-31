using Avalonia.Controls;
using Avalonia.Interactivity;
using Vault.Views;

namespace Vault.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void CreateAccount(object? sender, RoutedEventArgs e)
    {
        this.Content = new CreateAccount();
    }

    private void Login(object? sender, RoutedEventArgs e)
    {
        this.Content = new Login();
    }

    private void ForgetPassword(object? sender, RoutedEventArgs e)
    {
        
    }
}