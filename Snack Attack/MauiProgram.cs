using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Snack_Attack;
using Snack_Attack.Services;
using Snack_Attack.ViewModels;
using Snack_Attack.Pages;

namespace SnackAttack;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        
        builder.Services.AddSingleton<SnackAttackService>();
        builder.Services.AddSingleton<HomeViewModel>();
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<AllItemsViewModel>();
        builder.Services.AddSingleton<AllItemsPage>();
        builder.Services.AddSingleton<ItemDetailsPage>();
        builder.Services.AddSingleton<ItemDetailsViewModel>();
        builder.Services.AddSingleton<ItemsCartPage>();
        builder.Services.AddSingleton<ItemsCartViewModel>();



#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}