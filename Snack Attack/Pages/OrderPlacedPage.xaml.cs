namespace Snack_Attack.Pages;

public partial class OrderPlacedPage : ContentPage
{
    public OrderPlacedPage()
    {
        InitializeComponent();
        AnimateElements();
    }

    private  async void AnimateElements()
    {
        await CheckImage.FadeTo(1, 200);
        await CheckImage.ScaleTo(1.2, 300, Easing.SpringOut);
        await CheckImage.ScaleTo(1.0, 150, Easing.CubicOut);
        
        await OrderPlaced.FadeTo(1, 300);
        await OrderPlaced.TranslateTo(0, 0, 300, Easing.CubicOut);
        
        await ReturnHome.ScaleTo(1, 300, Easing.CubicOut);
        await ReturnHome.FadeTo(1, 300);
        await ReturnHome.TranslateTo(0, 0, 300, Easing.CubicOut);
    }
    private async void ReturnHomeButton_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}", animate: true); 
    }

}