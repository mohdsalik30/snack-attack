using Snack_Attack.ViewModels;

namespace Snack_Attack.Pages;

public partial class ItemsCartPage : ContentPage
{
    public ItemsCartPage(ItemsCartViewModel _itemsCartViewModel)
    {
        InitializeComponent();
        BindingContext = _itemsCartViewModel;
    }
}