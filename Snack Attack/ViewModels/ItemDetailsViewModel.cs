using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using Snack_Attack.Models;
using Snack_Attack.Pages;

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
    [RelayCommand]
    private async Task ViewCart()
    {
        if (SnackItem is not null && SnackItem.CartQuantity > 0)
        {
            
            await Shell.Current.GoToAsync(nameof(ItemsCartPage));
        }
        else
        {
            
            await Application.Current.MainPage.DisplayAlert(
                "Cart is empty", 
                "Please add at least one item to your cart before proceeding.", 
                "OK");
        }
    } 

}
