using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Snack_Attack.Models;

namespace Snack_Attack.ViewModels;


[QueryProperty(nameof(SnackItem), nameof(SnackItem))]
public partial class ItemDetailsViewModel : ObservableObject
{
    public ItemDetailsViewModel()
    {

    }

    [ObservableProperty] private SnackItem snackItem;

    [RelayCommand]
    private void AddItemToCart()
    {
        SnackItem.CartQuantity++;
    }

    [RelayCommand]
    private void RemoveItemFromCart()
    {
        if (SnackItem is not null && SnackItem.CartQuantity > 0)
            SnackItem.CartQuantity--;
    }

}
