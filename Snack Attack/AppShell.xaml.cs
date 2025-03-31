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
        
        Routing.RegisterRoute("MainPage", typeof(MainPage));
        Routing.RegisterRoute("HomePage", typeof(HomePage));
        Routing.RegisterRoute("AllItemsPage", typeof(AllItemsPage));
        Routing.RegisterRoute("ItemDetailsPage", typeof(ItemDetailsPage));
    }
}