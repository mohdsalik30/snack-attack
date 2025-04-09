using Snack_Attack.Pages;
using SnackAttack.Pages;

namespace SnackAttack;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        
        RegisterRoutes();
    }

    private void RegisterRoutes()
    {
        
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(AllItemsPage), typeof(AllItemsPage));
        Routing.RegisterRoute(nameof(ItemDetailsPage), typeof(ItemDetailsPage));
        Routing.RegisterRoute(nameof(ItemsCartPage), typeof(ItemsCartPage));
        
    }
}