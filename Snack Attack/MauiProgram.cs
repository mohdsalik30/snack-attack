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
        builder.Services.AddTransient<HomeViewModel>();
        builder.Services.AddTransient<HomePage>();
        builder.Services.AddTransient<AllItemsViewModel>();
        builder.Services.AddTransient<AllItemsPage>();
        builder.Services.AddTransient<ItemDetailsPage>();
        builder.Services.AddTransient<ItemDetailsViewModel>();
        builder.Services.AddTransient<ItemsCartPage>();
        builder.Services.AddTransient<ItemsCartViewModel>();



#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}