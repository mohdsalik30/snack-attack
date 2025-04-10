using System.Windows.Input;
using Snack_Attack.Pages;
using SnackAttack.Pages;

namespace SnackAttack;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        BindingContext = this;
        RegisterRoutes();
    }

    private void RegisterRoutes()
    {

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(AllItemsPage), typeof(AllItemsPage));
        Routing.RegisterRoute(nameof(ItemDetailsPage), typeof(ItemDetailsPage));
        Routing.RegisterRoute(nameof(ItemsCartPage), typeof(ItemsCartPage));
        Routing.RegisterRoute(nameof(OrderPlacedPage), typeof(OrderPlacedPage));
        Routing.RegisterRoute(nameof(ContactUsPage), typeof(ContactUsPage));
    }

    public ICommand NavigateToContactUsCommand => new Command(async () =>
    
    {
        Shell.Current.FlyoutIsPresented = false;
        await Shell.Current.GoToAsync(nameof(ContactUsPage));
    });
    
}