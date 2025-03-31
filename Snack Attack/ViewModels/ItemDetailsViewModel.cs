using CommunityToolkit.Mvvm.ComponentModel;
using Snack_Attack.Models;

namespace Snack_Attack.ViewModels;


[QueryProperty(nameof(SnackItem), nameof(SnackItem))]
public partial class ItemDetailsViewModel : ObservableObject
{
    public ItemDetailsViewModel()
    {
        
    }
    [ObservableProperty]
    private SnackItem snackItem;
}  