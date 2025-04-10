using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Alerts;
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
    public async Task DecreaseItemQuantity(SnackItem item)
    {
        if (item is null) return;
        
        if (item.CartQuantity > 1)
        {
            item.CartQuantity--;
            RecalculateTotalAmount();
            return;
        }

        item.CartQuantity = 0;

        var removedItem = item.Clone();
        SnackItems.Remove(item);
        RecalculateTotalAmount();
        
            var snackBar = Snackbar.Make("Item removed from cart", async() =>
            {
                removedItem.CartQuantity = 1;
                if (SnackItems.All(i => i.Name != removedItem.Name))
                {
                    SnackItems.Add(removedItem);
                }
 
                 RecalculateTotalAmount();
             }, "Undo", TimeSpan.FromSeconds(3));
             await snackBar.Show();
    }
 
     
 }