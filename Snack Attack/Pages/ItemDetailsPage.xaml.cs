using Snack_Attack.ViewModels;

namespace Snack_Attack.Pages;

public partial class ItemDetailsPage : ContentPage
{
   
    public ItemDetailsPage(ItemDetailsViewModel _itemDetailsViewModel)
    {
        InitializeComponent();
       
        BindingContext = _itemDetailsViewModel;
    }
}