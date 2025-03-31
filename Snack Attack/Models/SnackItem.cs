using CommunityToolkit.Mvvm.ComponentModel;

namespace Snack_Attack.Models;

public partial class SnackItem : ObservableObject
{
    public required string Name { get; set; }
    public required string Image { get; set; }
    public double Price { get; set; }

    [ObservableProperty, NotifyPropertyChangedFor(nameof(Amount))]
    private int cartQuantity;

    public double Amount => CartQuantity * Price;

    public SnackItem Clone() => (SnackItem)MemberwiseClone();
}