using Snack_Attack.Pages;

namespace SnackAttack.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    async void TapGestureRecognizer_Tapped(System.Object sender,
        Microsoft.Maui.Controls.TappedEventArgs e)
    {
        await AppShell.Current.GoToAsync($"//{nameof(HomePage)}");
    }
}