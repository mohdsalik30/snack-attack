using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Snack_Attack.Models;

namespace Snack_Attack.ViewModels;

public partial class ItemsCartViewModel : ObservableObject
{
    public ObservableCollection<SnackItem> SnackItems { get; set; } = new();

    [ObservableProperty]
    private double totalAmount;
    
    [ObservableProperty]
    private bool isCartEmpty;

    private void RecalculateTotalAmount()
    {
        TotalAmount = SnackItems.Sum(i => i.Amount);
        IsCartEmpty = SnackItems.Count == 0;
    }
    [RelayCommand]
    public void UpdateItemQuantity(SnackItem snackItem)
    {
        var existingItem = SnackItems.FirstOrDefault(i => i.Name == snackItem.Name);
        if (existingItem is not null)
        {
            existingItem.CartQuantity = snackItem.CartQuantity;
        }
        else
        {
            SnackItems.Add(snackItem);
        }
        RecalculateTotalAmount();
    }

    [RelayCommand]
    public void RemoveItemsFromCart(string name)
    {
        var itemToRemove = SnackItems.FirstOrDefault(i => i.Name == name);
        if (itemToRemove is not null)
        {
            SnackItems.Remove(itemToRemove);
            RecalculateTotalAmount();
        }
    }


    
    [RelayCommand]
    public void IncreaseItemQuantity(SnackItem item)
    {
        if (item is not null)
        {
            item.CartQuantity++;
            RecalculateTotalAmount();
        }
    }

    [RelayCommand]
    public void DecreaseItemQuantity(SnackItem item)
    {
        if (item is not null)
        {
            item.CartQuantity--;
            if (item.CartQuantity <= 0)
            {
                SnackItems.Remove(item);
            }
            RecalculateTotalAmount();
        }
    }
}