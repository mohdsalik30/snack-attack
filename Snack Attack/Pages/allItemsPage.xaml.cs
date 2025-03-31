using Snack_Attack.ViewModels;

namespace Snack_Attack.Pages;

public partial class AllItemsPage : ContentPage
{
    private readonly AllItemsViewModel _allItemsViewModel;

    public AllItemsPage(AllItemsViewModel allItemsViewModel)
    {
        InitializeComponent();
        _allItemsViewModel = allItemsViewModel;
        BindingContext = _allItemsViewModel;
    }
    
    public void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (BindingContext is AllItemsViewModel viewModel)
        {
            viewModel.SearchSnackItemCommand.Execute(e.NewTextValue);
        }
    }
}