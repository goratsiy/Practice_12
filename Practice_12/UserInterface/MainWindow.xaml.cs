// MainWindow.xaml.cs
using System.Windows;
using Practice_12.Models;


public partial class MainWindow : Window
{
    private Bank bank = new Bank();

    public MainWindow()
    {
        InitializeComponent();
        LoadClients();
    }

    private void LoadClients()
    {
        bank.Clients = DataStorage.LoadData();
        ClientList.ItemsSource = bank.Clients;
    }

    private void AddClient_Click(object sender, RoutedEventArgs e)
    {
        var newClient = bank.AddClient("New Client");
        ClientList.Items.Refresh();
        DataStorage.SaveData(bank.Clients);
    }

    private void OpenAccount_Click(object sender, RoutedEventArgs e)
    {
        if (ClientList.SelectedItem is Client client)
        {
            client.AddAccount(bank.CreateAccount(1000));
            MessageBox.Show("Account opened successfully!");
            DataStorage.SaveData(bank.Clients);
        }
    }
}
