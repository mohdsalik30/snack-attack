using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Snack_Attack.Models;
using Snack_Attack.Pages;
using Snack_Attack.Services;

namespace Snack_Attack.ViewModels;

[QueryProperty(nameof(CameFromSearch), nameof(CameFromSearch))]
public partial class AllItemsViewModel : ObservableObject
{
    private readonly SnackAttackService _service;

    public ObservableCollection<SnackItem> SnackItems { get; set; }

    public AllItemsViewModel(SnackAttackService service)
    {
        _service = service;
        SnackItems = new ObservableCollection<SnackItem>(_service.GetSnackItems());
    }

    [ObservableProperty]
    public bool cameFromSearch;

    [ObservableProperty]
    public string searchTerm = string.Empty;

    [RelayCommand]
    public void SearchSnackItem()
    {
        SnackItems.Clear();

        var results = string.IsNullOrWhiteSpace(SearchTerm)
            ? _service.GetSnackItems()
            : _service.SearchItems(SearchTerm);

        foreach (var item in results)
            SnackItems.Add(item);
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