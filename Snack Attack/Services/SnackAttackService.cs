using Snack_Attack.Models;

namespace Snack_Attack.Services;

public class SnackAttackService
{
    private static readonly IEnumerable<Models.SnackItem> _fastFood = new List<Models.SnackItem>
    {
        new Models.SnackItem { Name = "Chicken Burger 1", Image = "burger1.png", Price = 4.5, Description = "Crispy fried chicken fillet with cheese, lettuce and ketchup." },
        new Models.SnackItem { Name = "Chicken Burger 2", Image = "burger2.png", Price = 5.5, Description = "Crispy fried chicken fillet, 2 cheese, lettuce and Ketchup."},
        new Models.SnackItem { Name = "Chicken Burger Meal", Image = "burger3.png", Price = 6.5, Description = " Try the meal combo of Crispy fried chicket fillet, 2 cheese, lettuce and Ketchup with fries and cola."},
        new Models.SnackItem { Name = "Cheese Burger", Image = "cheeseburger.png", Price = 5.5, Description = "Original American cheese burger"},
        new Models.SnackItem { Name = "Chicken Wings", Image = "chicken_wings.png", Price = 1.2, Description = "Homemade rispy fried chicken wings"},
        new Models.SnackItem { Name = "Cola", Image = "cola.png", Price = 1, Description = "Coal can (300ml)"},
        new Models.SnackItem { Name = "Cola Bottle", Image = "cola_bottle.png", Price = 1.2, Description = "Same taste same cola in bottle (500ml)"},
        new Models.SnackItem { Name = "Lemon Soda", Image = "soda.png", Price = 1.2, Description = "The authentic sola with the taste of citrus in it for refreshment."},
        new Models.SnackItem { Name = "Fries", Image = "french_fries.png", Price = 1.5, Description = "Homemade fries"},
        new Models.SnackItem { Name = "Full Chicken", Image = "fried_chicken.png", Price = 12.5, Description = "Homemade crispy fried full chicken which is coked with homdmade marination and coked till perfection (8 pieces)."},
        new Models.SnackItem { Name = "Chicken", Image = "fried_chicken1.png", Price = 2, Description = "Homemade crispy fried  chicken legs which is cooked with homemade marination and cooked till perfection. "},
        new Models.SnackItem { Name = "Mayonnaise", Image = "mayonnaise.png", Price = 0.3, Description = "Original real mayonnaise"},
        new Models.SnackItem { Name = "Ketchup", Image = "tomato_sauce.png", Price = 0.3, Description = "Ketchup made from fresh tomatos"}
    };

  
    public static IEnumerable<Models.SnackItem> GetAllFastFood() => _fastFood;

   
    public IEnumerable<Models.SnackItem> GetPopularItems(int count = 6) =>
        _fastFood.OrderBy(p => Guid.NewGuid()).Take(count);

    public IEnumerable<SnackItem> GetSnackItems() =>
        _fastFood;
    public IEnumerable<Models.SnackItem> SearchItems(string searchTerm) =>
        string.IsNullOrWhiteSpace(searchTerm)
            ? _fastFood
            : _fastFood.Where(p => p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));
}