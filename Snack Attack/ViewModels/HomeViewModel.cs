using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Snack_Attack.Models;
using Snack_Attack.Pages;
using Snack_Attack.Services;

namespace Snack_Attack.ViewModels;

public partial class HomeViewModel : ObservableObject
{
    private readonly SnackAttackService _snackAttackService;

    public ObservableCollection<SnackItem> Snacks { get; set; }

    public HomeViewModel(SnackAttackService snackAttackService)
    {
        _snackAttackService = snackAttackService;
        Snacks = new ObservableCollection<SnackItem>(_snackAttackService.GetPopularItems());
    }
    
    [RelayCommand]
    private async Task GoToAllItemsPage(bool fromSearch = false)
    {
        var parameters = new Dictionary<string, object>
        {
            {nameof(AllItemsViewModel.CameFromSearch), fromSearch}
        };

        await Shell.Current.GoToAsync(nameof(AllItemsPage), parameters);
    }
    [RelayCommand]
    private async Task GoToItemDetailsPage(SnackItem snackItem)
    {
        var parameters = new Dictionary<string, object>
        {
            { nameof(ItemDetailsViewModel.SnackItem), snackItem }
        };

        await Shell.Current.GoToAsync(nameof(ItemDetailsPage), parameters);
    }

}