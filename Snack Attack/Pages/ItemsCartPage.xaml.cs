using Microsoft.Maui.Controls;
using Snack_Attack.ViewModels;

namespace Snack_Attack.Pages;

public partial class ItemsCartPage : ContentPage
{
    private readonly ItemsCartViewModel _itemsCartViewModel;
    public ItemsCartPage(ItemsCartViewModel itemsCartViewModel)
    {
        _itemsCartViewModel = itemsCartViewModel;
        InitializeComponent();
        BindingContext = _itemsCartViewModel;
        
        Shell.SetBackButtonBehavior(this, new BackButtonBehavior { IsVisible = false });
    }

    
}