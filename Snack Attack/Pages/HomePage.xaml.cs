using Snack_Attack.ViewModels;
namespace Snack_Attack.Pages;

public partial class HomePage : ContentPage
{
    private readonly HomeViewModel _homeViewModel;
    public HomePage(HomeViewModel homeViewModel)
    {
        InitializeComponent();
        _homeViewModel = homeViewModel;
        BindingContext = _homeViewModel;
    }
}