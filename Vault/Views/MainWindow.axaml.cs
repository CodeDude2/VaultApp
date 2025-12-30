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
}